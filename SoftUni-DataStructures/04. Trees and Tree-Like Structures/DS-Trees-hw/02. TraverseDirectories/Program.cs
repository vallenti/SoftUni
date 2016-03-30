﻿using System;
using System.IO;
using System.Linq;

namespace _02.TraverseDirectories
{
    class Program
    {
        public static void Main(string[] args)
        {
            const string startFolderPath = @"C:\Windows";
            Folder startFolder = new Folder(startFolderPath);
            BuildTree(startFolder);

            Console.WriteLine(GetFolderSize(startFolder));
        }

        private static void BuildTree(Folder folder)
        {
            Console.WriteLine(folder.Name);
            FileInfo[] files = new FileInfo[] { };
            try
            {
                files = new DirectoryInfo(folder.Name).GetFiles();
            }
            catch (UnauthorizedAccessException)
            {

            }

            foreach (var childFile in files)
            {
                File file = new File(childFile.FullName, childFile.Length);
                folder.Files.Add(file);
            }

            DirectoryInfo[] folders = new DirectoryInfo[] { };
            try
            {
                folders = new DirectoryInfo(folder.Name).GetDirectories();
            }
            catch (UnauthorizedAccessException uaex)
            {
            }

            foreach (var childFolder in folders)
            {
                Folder customFolder = new Folder(childFolder.FullName);
                folder.ChildFolders.Add(customFolder);
                BuildTree(customFolder);
            }
        }

        public static long GetFolderSize(Folder rootFolder)
        {
            if (rootFolder == null)
            {
                return 0;
            }

            long childSum = 0;

            foreach (var folder in rootFolder.ChildFolders)
            {
                childSum += GetFolderSize(folder);
            }

            return childSum + rootFolder.Files.Sum(f => f.Size);
        }
    }
}
