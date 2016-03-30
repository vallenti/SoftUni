using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        DateTime startTime = DateTime.Parse("01:00 PM");
        DateTime endTime = DateTime.Parse("03:00 AM");
        DateTime checkTime;
        string time = Console.ReadLine();
        Console.WriteLine(startTime);
        Console.WriteLine(endTime);

        if (DateTime.TryParseExact(time, "hh:mm tt", new CultureInfo("en-US"), DateTimeStyles.None, out checkTime))
        {
            if (checkTime >= startTime || checkTime <= endTime)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
        Console.WriteLine(checkTime);

    }
}

