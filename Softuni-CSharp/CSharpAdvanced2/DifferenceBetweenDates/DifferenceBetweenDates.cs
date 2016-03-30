using System;
using System.Globalization;

class DifferenceBetweenDates
{
    static void Main()
    {
        string firstDate = Console.ReadLine();
        string lastDate = Console.ReadLine();
        string pattern = "d.MM.yyyy";
        DateTime startDate, endDate;
        
        DateTime.TryParseExact(firstDate, pattern, null, DateTimeStyles.None, out startDate);
        DateTime.TryParseExact(lastDate, pattern, null, DateTimeStyles.None, out endDate);
       
        Console.WriteLine((endDate - startDate).TotalDays);

    }
}
