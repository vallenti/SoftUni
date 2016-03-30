using System;

class Program
{
    static void Main()
    {
        string leapYear = Console.ReadLine();
        double holidays = double.Parse(Console.ReadLine());
        double hometown = double.Parse(Console.ReadLine());
        double plays = 0;
        plays = (holidays / 2) + hometown + ((52 - hometown) * (2d/3));
        if (leapYear == "t")
        {
            plays += 3;
        }
        Console.WriteLine(Math.Floor(plays));
    }
}

