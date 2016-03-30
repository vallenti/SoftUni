using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenerateRandomNumbers
{
    class GenerateRandomNumbers
    {
        static void Main(string[] args)
        {
            Random randGen = new Random();
            Console.WriteLine(randGen.Next(100, 201));
            Console.WriteLine(randGen.Next(100, 201));
            Console.WriteLine(randGen.Next(100, 201));
            Console.WriteLine(randGen.Next(100, 201));
            Console.WriteLine(randGen.Next(100, 201));
            Console.WriteLine(randGen.Next(100, 201));
            Console.WriteLine(randGen.Next(100, 201));
            Console.WriteLine(randGen.Next(100, 201));
            Console.WriteLine(randGen.Next(100, 201));
            Console.WriteLine(randGen.Next(100, 201));
        }
    }
}
