using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_MultiplyArray
{
    class MultiplyArray
    {
        static void Main()
        {
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
            }
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
