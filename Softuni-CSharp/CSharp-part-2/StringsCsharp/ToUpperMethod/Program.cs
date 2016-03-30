using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToUpperMethod
{
    class Program
    {
        static void Main()
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            int startIndex = text.IndexOf("<upcase>");

            while (text.IndexOf("<upcase>") != -1)
            {
                startIndex = text.IndexOf("<upcase>");
                int endIndex = text.IndexOf("</upcase>", startIndex) - 1;
                string word = text.Substring(startIndex + 8, endIndex - startIndex - 7);
                text = text.Replace(word, word.ToUpper());
                text = text.Remove(startIndex, 8);
                text = text.Remove(endIndex-7,9);
            }
            Console.WriteLine(text);
        }
    }
}
