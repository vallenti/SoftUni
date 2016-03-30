using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            for (int i = 1; i <= 10; i++)
            {
                try
                {
                    Console.Write("number {0} = ",i);
                    int number = ReadNumber(start, 100);
                    start = number;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number. Try again.");
                    i--;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Number out of range. Try again");
                    i--;
                }
            }
        }

        static int ReadNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());
            if(number <= start || number >= end)
            {
                throw new ArgumentOutOfRangeException(String.Format("Input number is not in the range [{0}, {1}]", start, end));
            }
            return number;
        }
    }
}
