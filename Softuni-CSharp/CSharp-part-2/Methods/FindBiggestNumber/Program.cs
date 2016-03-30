using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindBiggestNumber
{
    class Program
    {
        static int GetMax(int x, int y)
        {
            if (x > y)
                return x;
            else
                return y;
        }
        static void Main(string[] args)
        {
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c: ");
            int c = int.Parse(Console.ReadLine());
            int biggerAB = GetMax(a, b);
            int biggestNumber = GetMax(biggerAB, c);
            Console.WriteLine("Biggest number is {0}", biggestNumber);
        }
    }
}
