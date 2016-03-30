using System;

class Program
{
    static void Main()
    {
        string leapYear = Console.ReadLine();
        double holidays = double.Parse(Console.ReadLine());
        double hometown = double.Parse(Console.ReadLine());
        double plays = 0;
        plays = hometown + ((48 - hometown) * (3d / 4)) + (holidays * (2d / 3));
        if (leapYear == "leap")
        {
            plays += (plays*0.15);
        }
        Console.WriteLine(Math.Floor(plays));
    }
}

