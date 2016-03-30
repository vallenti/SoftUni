namespace VehicleParkSystem.Core
{
    using System;
    using Interfaces;
    using Commands;
    using System.IO;

    class Engine : IEngine
    {
        private CommandExecutor executor;

        Engine (CommandExecutor executor)
        {
            this.executor = executor;
        }

        public Engine(): this (new CommandExecutor())
        {
        }

        public void Run ()
        {
            while(true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == null) break;

                commandLine.Trim();
                if (!string.IsNullOrEmpty(commandLine))

                    try
                    {
                        var comand = new Command(commandLine);
                        string commandResult = executor.ReturnCommand(comand);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(commandResult);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    catch(Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(ex.Message);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
            }
        }
    }
}