using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBrackets
{
    class CheckBrackets
    {
        static void Main()
        {
            string expression = "((a+b)/5-d)";
            int leftBracket = 0;
            int rightBracket = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    leftBracket++;
                }
                if (expression[i] == ')')
                {
                    rightBracket++;
                }
            }
            if (leftBracket == rightBracket)
            {
                Console.WriteLine("all brackets are correct");
            }
            else
            {
                Console.WriteLine("brackets are incorrect");
            }
        }
    }
}
