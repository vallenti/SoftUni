using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        public static string ReverseText(string text)
        {
            StringBuilder reversedStr = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedStr.Append(text[i]);
            }
            return reversedStr.ToString();
        }
        static void Main()
        {
            string str = Console.ReadLine();
            string reversed = ReverseText(str);
            Console.WriteLine(reversed);
        }
    }
}
