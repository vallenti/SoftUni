using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SumAndAverage
{
    class SumAndAverageListProgram
    {
        static void Main()
        {
            long sum = 0;
            double average = 0;
            try
            {
                List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
                sum = sequence.Sum();
                average = sequence.Average();
            }
            catch(FormatException)
            {

            }
            finally
            {
                Console.WriteLine("Sum={0}; Average={1}", sum, average);
            }
        }
    }
}
