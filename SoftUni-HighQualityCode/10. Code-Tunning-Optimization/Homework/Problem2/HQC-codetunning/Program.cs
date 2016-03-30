using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQC_codetunning
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            List<TimeSpan> allTimes = new List<TimeSpan>();
            for (int i = 0; i < 500; i++)
            {
                double a = 123456789.34565478678789;
                decimal b = 987654321.1234353465476549323823854545m;
                sw.Start();
                Math.Sqrt(a);
                sw.Stop();
                allTimes.Add(sw.Elapsed);
                sw.Reset();
            }
            
            double doubleAverageTicks = allTimes.Average(timeSpan => timeSpan.Ticks);
            Console.WriteLine(doubleAverageTicks);
        }
    }
}
