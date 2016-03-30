using System;

class PrintCirclesPerimAndArea
{
    static void Main()
    {
        int radius = int.Parse(Console.ReadLine());
        Console.WriteLine(2*Math.PI*radius);
        Console.WriteLine(Math.PI*radius*radius);
    }
}

