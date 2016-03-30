using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SayHello
{
    class Program
    {
        static void PrintText(string name)
        {
            Console.WriteLine("Hello, {0}", name);
        }

        static void Main()
        {
            string name = Console.ReadLine();
            PrintText(name);
        }
    }
}
