using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeapYear1
{
    class LeapYear1
    {
        static void Main()
        {
            int year = int.Parse(Console.ReadLine());
            bool isLeap = DateTime.IsLeapYear(year);
            if (isLeap)
            {
                Console.WriteLine("The year is leap!");
            }
            else
            {
                Console.WriteLine("The year is not leap!");
            }
        }
    }
}
