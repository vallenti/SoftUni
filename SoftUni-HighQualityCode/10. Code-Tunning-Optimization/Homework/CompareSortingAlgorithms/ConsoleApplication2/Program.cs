using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n * 3;
            int outterDotCount = n;
            int poundCount = n;
            char dot = '.';
            char pound = '#';
            Console.WriteLine(new string(dot,n)+new string(pound, n)+new string(dot, n));
            Console.WriteLine(new string(dot, n-2)+new string(pound, 3)+new string(dot, n-2)+new string(pound,3)+new string(dot, n-2));
            outterDotCount -= 4;
            int innerDotCount = 2;
            for (int i = 0; i < (n + 1 - 4)/2; i++)
            {
                string zero = new string(dot, outterDotCount);
                string one = new string(pound, 2);
                string two = new string(dot, innerDotCount);
                string three = new string(pound, 1);
                string four = new string(dot, n-2);
                Console.WriteLine("{0}{1}{2}{3}{4}{3}{2}{1}{0}",zero, one, two, three, four);
                outterDotCount -= 2;
                innerDotCount += 2;
            }
            outterDotCount += 2;
            innerDotCount -= 2;
            for (int i = 0; i < (n + 1 - 4) / 2; i++)
            {
                string zero = new string(dot, outterDotCount);
                string one = new string(pound, 2);
                string two = new string(dot, innerDotCount);
                string three = new string(pound, 1);
                string four = new string(dot, n - 2);
                Console.WriteLine("{0}{1}{2}{3}{4}{3}{2}{1}{0}", zero, one, two, three, four);
                outterDotCount += 2;
                innerDotCount -= 2;
            }

            outterDotCount = n;
            poundCount = n;
            Console.WriteLine(new string(dot, n-2)+new string(pound, 3)+new string(dot, n-2)+new string(pound,3)+new string(dot, n-2));
            Console.WriteLine(new string(dot,n)+new string(pound, n)+new string(dot, n));
        }
    }
}
