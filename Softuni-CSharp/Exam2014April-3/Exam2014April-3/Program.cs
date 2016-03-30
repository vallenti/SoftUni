using System;

class Program
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        byte percent = byte.Parse(Console.ReadLine());
        double workDays = days - (days * 0.1);
        double workHours = Math.Floor(workDays * 12 * (percent / 100.0));
        if (hours > workHours)
        {
            Console.WriteLine("No");
            Console.WriteLine(-Math.Abs(hours - workHours));
        }
        else
        {
            Console.WriteLine("Yes");
            Console.WriteLine(Math.Abs(hours-workHours));
        }
    }
}

