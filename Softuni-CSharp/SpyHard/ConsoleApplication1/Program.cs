using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            //DateTime today = DateTime.Now.Date;
            DateTime today = new DateTime(2015,1,1);
            DateTime exam = new DateTime(2015, 4, 28);
            int days = (int)(exam - today).TotalDays;
            string binNum = Convert.ToString(days, 2);
            Console.WriteLine("{0}, you have only {1} days to apply for the spring semester at Software University!",name,binNum);
        }
    }
}
