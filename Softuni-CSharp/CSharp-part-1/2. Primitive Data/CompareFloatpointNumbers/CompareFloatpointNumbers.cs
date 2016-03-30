using System;

class CompareFloatpointNumbers
{
    static void Main()
    {
        decimal a = 5.0000000001m;
        decimal b = 5.0000000003m;
        a = Math.Round(a, 6);
        b = Math.Round(b, 6);
        bool equals = (a == b);
        Console.WriteLine(equals);
    }
}

