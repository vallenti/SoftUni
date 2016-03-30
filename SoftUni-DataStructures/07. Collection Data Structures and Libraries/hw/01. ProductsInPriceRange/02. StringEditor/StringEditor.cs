namespace _02.StringEditor
{
    using System;
    using Wintellect.PowerCollections;

    class StringEditor
    {
        const string AppendCommand = "APPEND";
        const string InsertCommand = "INSERT";
        const string DeleteCommand = "DELETE";
        const string ReplaceCommand = "REPLACE";
        const string PrintCommand = "PRINT";
        const string EndCommand = "END";
        const string InvalidCommand = "Invalid command.";
        const string SuccessfullyExecutedCommand = "OK";
        const string UnSuccessfullyExecutedCommand = "ERROR";

        static BigList<char> text = new BigList<char>();

        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while(command != EndCommand)
            {
                string[] commandTokens = command.Split();
                switch (commandTokens[0])
                {
                    case AppendCommand:
                        string textToAppend = commandTokens[1];
                        AppendText(textToAppend);
                        break;
                    case InsertCommand:
                        int position = int.Parse(commandTokens[1]);
                        string textToInsert = commandTokens[2];
                        InsertText(position, textToInsert);
                        break;
                    case DeleteCommand:
                        int startIndex = int.Parse(commandTokens[1]);
                        int count = int.Parse(commandTokens[2]);
                        DeleteText(startIndex, count);
                        break;
                    case ReplaceCommand:
                        int replaceIndex = int.Parse(commandTokens[1]);
                        int replaceCount = int.Parse(commandTokens[2]);
                        string replaceString = commandTokens[3];
                        ReplaceText(replaceIndex, replaceCount, replaceString);
                        break;
                    case PrintCommand:
                        PrintText();
                        break;
                    default:
                        Console.WriteLine(InvalidCommand);
                        break;
                }

                command = Console.ReadLine();
            }
        }

        private static void PrintText()
        {
            foreach (char symbol in text)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }

        private static void ReplaceText(int replaceIndex, int replaceCount, string replaceString)
        {
            if (replaceIndex < 0 || replaceIndex + replaceCount >= text.Count || replaceCount < 0)
            {
                Console.WriteLine(UnSuccessfullyExecutedCommand);
                return;
            }

            text.RemoveRange(replaceIndex, replaceCount);
            text.InsertRange(replaceIndex, replaceString);
            Console.WriteLine(SuccessfullyExecutedCommand);
        }

        private static void DeleteText(int startIndex, int count)
        {
            if(startIndex < 0 || startIndex + count >= text.Count || count < 0)
            {
                Console.WriteLine(UnSuccessfullyExecutedCommand);
                return;
            }

            text.RemoveRange(startIndex, count);
            Console.WriteLine(SuccessfullyExecutedCommand);
        }

        private static void InsertText(int position, string textToInsert)
        {
            if(position < 0 || position >= text.Count)
            {
                Console.WriteLine(UnSuccessfullyExecutedCommand);
                return;
            }

            text.InsertRange(position, textToInsert);
            Console.WriteLine(SuccessfullyExecutedCommand);
        }

        private static void AppendText(string textToAppend)
        {
            text.AddRange(textToAppend);
            Console.WriteLine(SuccessfullyExecutedCommand);
        }
    }
}
