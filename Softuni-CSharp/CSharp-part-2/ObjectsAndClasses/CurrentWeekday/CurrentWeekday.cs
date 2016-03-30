using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurrentWeekday
{
    class CurrentWeekday
    {
        static void Main()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today.DayOfWeek);
        }
    }
}
