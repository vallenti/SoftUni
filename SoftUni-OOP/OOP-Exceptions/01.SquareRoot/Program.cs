using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(CalculateSqrt(number));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number");
            }
        }

        static double CalculateSqrt(int number)
        {
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException("Number cannot be negative");
            }
            return Math.Sqrt(number);
        }
    }
}
