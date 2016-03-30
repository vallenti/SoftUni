using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColculateSum
{
    class ColculateSum
    {
        static void Main()
        {
            string[] numbersStr = Console.ReadLine().Split(' ');
            int[] numbers = new int[numbersStr.Length];
            int sum = 0;
            for (int i = 0; i < numbersStr.Length; i++)
            {
                numbers[i] = int.Parse(numbersStr[i]);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
