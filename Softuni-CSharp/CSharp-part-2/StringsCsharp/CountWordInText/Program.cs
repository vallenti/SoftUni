using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWordInText
{
    class Program
    {
        static void Main()
        {
            string quote = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string keyword = "in";
            int keywordCounter = 0;
            int index = quote.IndexOf(keyword);
            if (index != -1)
            {
                keywordCounter++;
                while (index != -1)
                {
                    keywordCounter++;
                    index = quote.IndexOf(keyword, index + 1);
                }
            }
            Console.WriteLine(keywordCounter);
        }
    }
}
