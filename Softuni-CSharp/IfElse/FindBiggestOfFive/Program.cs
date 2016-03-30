using System;

class FindBiggestOfFive
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double biggest = double.MinValue;
        Console.WriteLine();
        if ((a >= b) && (a >= c) && (a >= d) && (a >= e))
        {
            biggest = a;
        }
        if ((b >= a) && (b >= c) && (b >= d) && (b >= e))
        {
            biggest = b;
        }
        if ((c >= a) && (c >= b) && (c >= d) && (c >= e))
        {
            biggest = c;
        }
        if ((d >= a) && (d >= b) && (d >= c) && (d >= e))
        {
            biggest = d;
        }
        if ((e >= a) && (e >= b) && (e >= c) && (e >= d))
        {
            biggest = e;
        }
        Console.WriteLine(biggest);
    }
}
