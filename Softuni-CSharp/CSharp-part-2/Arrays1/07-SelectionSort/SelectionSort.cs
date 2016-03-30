using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            int[] array = { 15, 2, 10, 5, 9, 1, 11, 55, 7, 13 };
            int length = array.Length;
            int minIndex, temp;
            for(int i = 0;i<length;i++)
            {
                minIndex = i;
                for (int k = i; k < length; k++)
                {   
                    if(array[minIndex]>array[k])
                    {
                        minIndex = k;
                    }
                }
                temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;

                
            }
            foreach (var num in array)
            {
                Console.Write(num+" ");
            }
        }
    }
}
