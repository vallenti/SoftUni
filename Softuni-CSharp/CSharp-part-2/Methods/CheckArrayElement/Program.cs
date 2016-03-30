using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckArrayElement
{
    class Program
    {
        static bool CheckElement(int[] array, int arrayIndex)
        {
            if (array[arrayIndex] > array[arrayIndex - 1] && array[arrayIndex] > array[arrayIndex + 1])
                return true;
            else
                return false;
        }
        static void Main()
        {
            int[] array = new int[] {1,2,3,43,5,13,7,8,8,0,10,15 };
            int arrayIndex = int.Parse(Console.ReadLine());
            if (CheckElement(array, arrayIndex))
            {
                Console.WriteLine("Element is bigger than its neighbours");
            }
            else
            {
                Console.WriteLine("Element is not bigger than its neighbours");
            }
        }
    }
}
