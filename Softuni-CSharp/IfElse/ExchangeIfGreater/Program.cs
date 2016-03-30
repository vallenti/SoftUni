using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Please input 2 variables (on separte lines):");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            double c = a;
            a = b;
            b = c;
        }
        Console.WriteLine(a+" "+b);
    }
}

