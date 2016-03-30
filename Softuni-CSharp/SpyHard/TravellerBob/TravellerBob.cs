using System;

class TravellerBob
{
    static void Main()
    {
        string year = Console.ReadLine();
        int contractMonths = int.Parse(Console.ReadLine());
        int familyMonths = int.Parse(Console.ReadLine());
        int normalMonths = 12 - contractMonths - familyMonths;
        double totalTravells = 0;
        totalTravells += contractMonths * 12 + familyMonths * 4 + (12*normalMonths)*(3/5.0);
        if (year == "leap")
        {
            totalTravells += totalTravells * 0.05;
        }
        Console.WriteLine(Math.Floor(totalTravells));
    }
}

