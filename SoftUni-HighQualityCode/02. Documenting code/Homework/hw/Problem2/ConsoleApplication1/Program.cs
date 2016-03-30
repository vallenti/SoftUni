using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string secword = Console.ReadLine();
            string message = Console.ReadLine();
            

            char[] decodesec;
            decodesec = secword.ToCharArray();

            int firstWord = 0;

            for (int i = 0; i < decodesec.Length; i++)
            {
                firstWord += (int)decodesec[i];
            }

            string finalmask = firstWord.ToString();
            char[] maskfinal = finalmask.ToCharArray();
            int masknumber = 0;
            int maskvalue = 0;

            for (int i = 0; i < maskfinal.Length; i++)
            {
                masknumber = (int)Char.GetNumericValue(maskfinal[i]);
                maskvalue += masknumber;
            }
            Console.WriteLine(maskvalue);

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                if(message[i] % maskvalue == 0)
                {
                    result.Insert(0, (char)(message[i] + maskvalue));
                }
                else
                {
                    result.Insert(0, (char)(message[i] - maskvalue));
                }
            }
            Console.WriteLine(result);
        }
    }
}