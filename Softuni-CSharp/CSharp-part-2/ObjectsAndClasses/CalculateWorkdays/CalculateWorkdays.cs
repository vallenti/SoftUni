using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CalculateWorkdays
{
    class CalculateWorkdays
    {
        static void Main()
        {
            DateTime[] holidays = new DateTime[]{
                new DateTime(2013, 3, 5),
                new DateTime(2013, 5, 1),
                new DateTime(2013, 5, 24),
                new DateTime(2013, 3, 6),
            };
            bool isHoliday = false;
            int workDaysCounter = 0;

            string[] date = Console.ReadLine().Split('/');
            int year = int.Parse(date[0]);
            int month = int.Parse(date[1]);
            int day = int.Parse(date[2]);


            DateTime startDay = DateTime.Now.Date;
            DateTime endDay = new DateTime(year, month, day);
            int timeLength = Math.Abs((endDay - startDay).Days);
           


            for (int i = 1; i < timeLength ; i++)
            {
                startDay = startDay.AddDays(i);
                if (startDay.DayOfWeek != DayOfWeek.Saturday && startDay.DayOfWeek != DayOfWeek.Sunday)
                {
                    for (int k = 0; k < holidays.Length; k++)
                    {
                        if (startDay.Day == holidays[k].Day)
                        {
                            isHoliday = true;
                            break;
                        }
                    }
                    if (!isHoliday)
                    {
                        workDaysCounter++;
                    }
                    isHoliday = false;
                }
            }
            Console.WriteLine(workDaysCounter);
            
            
        }
    }
}
