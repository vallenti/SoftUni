using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CompareSortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n10 = InitializeArray(10);
            int[] n50 = InitializeArray(50);
            int[] n100 = InitializeArray(100);
            int[] n1000 = InitializeArray(1000);
            int[] n10000 = InitializeArray(10000);
            int[] n100000 = InitializeArray(100000);
            int[] n1000000 = InitializeArray(1000000);
            int[] n10000000 = InitializeArray(10000000);
            Console.WriteLine("initialized");
            Stopwatch timer = new Stopwatch();
            timer.Start();
            SortStrategies.QuickSort(n10000000, 0, n10000000.Length - 1);
            timer.Stop();
            Console.WriteLine(timer.Elapsed);

        }

        private static int[] InitializeArray(int arraySize)
        {
            int[] result = new int[arraySize];
            Random rand = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                result[i] = rand.Next(int.MinValue, int.MaxValue);
            }

            return result;
        }
    }
}
