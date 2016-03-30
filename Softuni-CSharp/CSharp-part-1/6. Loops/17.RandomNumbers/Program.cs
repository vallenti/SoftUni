using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r1 = new Random();
            Random r2 = new Random(2);
            int n = int.Parse(Console.ReadLine());
            int temp = 0;
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i+1;
            }
           
            for (int i = 0; i < array.Length; i++)
            {
                int randNum1 = r1.Next(array.Length);
                int randNum2 = r2.Next(array.Length);
                temp = array[randNum1];
                array[randNum1] = array[randNum2];
                array[randNum2] = temp;
            }
            foreach (var num in array)
            {
                Console.Write(num+" ");
            }
        }
    }
}
