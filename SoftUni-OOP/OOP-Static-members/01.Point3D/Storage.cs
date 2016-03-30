using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    static class Storage
    {
        

        public static void SavePath(Path3D points, string filePath)
        {
            StreamWriter writer = new StreamWriter(filePath);
            using (writer)
            {
                foreach(Point3D point in points.Path)
                {
                    writer.WriteLine(point.X + " " + point.Y + " " + point.Z);
                }
            }
        }
        public static Path3D LoadPath(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            List<Point3D> path = new List<Point3D>();
            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    int[] coords = reader.ReadLine().Split().Select(int.Parse).ToArray();
                    path.Add(new Point3D(coords[0], coords[1], coords[2]));
                }
            }
            return new Path3D(path);
        }
    }
}
