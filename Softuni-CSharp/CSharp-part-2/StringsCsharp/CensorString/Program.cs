using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensorString
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            Console.WriteLine(text.Length);
            if (text.Length > 20)
            {
                string part1 = text.Substring(0, 20);
                string part2 = text.Substring(20);
                for (int i = 0; i < part2.Length; i++)
                {
                    part2 = part2.Replace(part2[i].ToString(), "*");
                }
                text = part1 + part2;
            }
            Console.WriteLine(text);
        }
    }
}
