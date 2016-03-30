using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.FibonacciSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 1;
            long sum = 2;
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine(0);
            }
            else if (n == 2)
            {
                Console.WriteLine(1);
            }
            else if (n == 3)
            {
                Console.WriteLine(2);
            }
            else
            {
                for (int i = 4; i <= n; i++)
                {
                    a = b;
                    b = c;
                    c = a + b;
                    sum += c;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
