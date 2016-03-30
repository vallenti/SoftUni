using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseNumber
{
    class Program
    {
        static string ReverseNumber(int num)
        {
            string number = num.ToString();
            string reversedNumber="";
            for (int i = number.Length-1; i >=0 ; i--)
            {
                reversedNumber += number[i];
            }
            return reversedNumber;
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int reversedNumber = int.Parse(ReverseNumber(number));
            string lower = new String('a', 5);
            string upper = lower.ToUpper();
            
            Console.WriteLine(reversedNumber);
        }
    }
}
