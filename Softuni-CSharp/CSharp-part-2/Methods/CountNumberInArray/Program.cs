using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountNumberInArray
{
    class Program
    {
        static int CountNumberInArray(int[] arr, int number)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number) count++;
            }
            return count;
        }
        static void Main()
        {
            int[] array = new int[] { 1, 5, 2, 2, 5, 2, 1, 6, 3, 4, 4, 8 };
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(CountNumberInArray(array, num)); 
        }
    }
}
