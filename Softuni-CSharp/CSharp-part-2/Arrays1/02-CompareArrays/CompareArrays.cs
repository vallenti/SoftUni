using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            List<int> array1 = new List<int>();
            List<int> array2 = new List<int>();

            int input = int.Parse(Console.ReadLine());
            while (input != -1)
            {
                array1.Add(input);
                input = int.Parse(Console.ReadLine());
            }

            int input2 = int.Parse(Console.ReadLine());
            while (input2 != -1)
            {
                array2.Add(input2);
                input2 = int.Parse(Console.ReadLine());
            }

            bool isEqual = true;
            if (array1.Count == array2.Count)
            {
                //check for elements
                for (int i = 0; i < array1.Count; i++)
                {
                    if (array1[i] != array2[i])
                    {
                        isEqual = false;
                        break;
                    }
                }
            }
            else
            {
                isEqual = false;
            }
            Console.WriteLine("Arrays are equals: {0}", isEqual);
        }
    }
}
