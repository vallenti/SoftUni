using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringExtentionDocumentation
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "test string";
            Console.WriteLine(StringExtensions.ToValidLatinFileName(testString));
        }
    }
}
