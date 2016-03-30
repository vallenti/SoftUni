using BuhtigIssueTracker.Interfaces;
using System;

namespace BuhtigIssueTracker.Core
{
    public class Engine : IEngine
    {
        private CommandDispatcher d;

        public Engine(CommandDispatcher d)
        {
            this.d = d;
        }

        public Engine()
            : this(new CommandDispatcher())
        {
        }

        public void Run()
        {
            while (true)
            {
                string url = Console.ReadLine();
                if (url == null)
                {
                    break;
                }
                url = url.Trim();

                try
                {
                    IEndpoint ep =  new Endpoint(url);
                    string viewResult = this.d.DispatchAction(ep);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(viewResult);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }
    }
}
