using System;
using System.Collections.Generic;
using System.Text;
using Wintellect.PowerCollections;

namespace _02.TextEditor
{
    class Program
    {
        static BigList<char> text = new BigList<char>();

        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (true)
            {
                string[] commandTokens = command.Split();
                switch (commandTokens[0])
                {
                    case "INSERT":
                        string textToInsert = commandTokens[1];
                        text.AddRangeToFront(textToInsert);
                        break;
                    case "APPEND":
                        string textToAppend = commandTokens[1];
                        text.AddRange(textToAppend);
                        break;
                    case "DELETE":
                        int startIndex = int.Parse(commandTokens[1]);
                        int count = int.Parse(commandTokens[2]);
                        text.RemoveRange(startIndex, count);
                        break;
                    case "PRINT":
                        PrintText();
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        break;
                }

                command = Console.ReadLine();
            }
        }


        private static void PrintText()
        {
            StringBuilder result = new StringBuilder();
            foreach (char symbol in text)
            {
                result.Append(symbol);
            }
            Console.WriteLine(result.ToString());
        }
    }
}

