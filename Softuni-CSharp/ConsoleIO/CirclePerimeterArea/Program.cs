using System;

class PrintCircleInfo
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F2}",2*Math.PI*r);
        Console.WriteLine("{0:F2}",Math.PI*r*r);
    }
}

