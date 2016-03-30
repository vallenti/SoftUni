using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace DownloadFile
{
    class Program
    {
        static void Main()
        {
            string beeers = "Zagorka, Tuborg, Amstel, Kamenitza";
            char[] separators = new char[]{',', ' '};
            string[] beerArray = beeers.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (var beer in beerArray)
            {
                Console.WriteLine(beer);
            }
            
        }
    }
}
