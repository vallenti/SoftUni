using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindMaxSequence
{
    class FindMaxSequence
    {
        static void Main()
        {
            int[] array = {1,1,1,1,1,1,2,3,4,5,1,1,5,5,5,5,4};
            int start = 0;
            int len = 1;
            int bestStart = start;
            int bestLen = len;
            for (int i = 0; i < array.Length-1; i++)
            {

                if (array[i]==array[i+1])
                {
                    start = (i + 1) - len;
                    len++;
                }
                else
                {
                    len = 1;
                    continue;
                }
                if (len > bestLen)
                {
                    bestLen = len;
                    bestStart = start;
                }
            }
            for (int i = bestStart; i < bestStart+bestLen; i++)
            {
                Console.Write(array[i]+" ");
            }
        }
    }
}
