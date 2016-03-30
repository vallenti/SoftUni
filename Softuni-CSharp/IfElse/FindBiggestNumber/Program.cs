using System;

class FindBiggestNumber
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double biggest = double.MinValue;
        if (a > b)
        {
            biggest = a;
        }
        else
        {
            biggest = b;
        }
        if (c > biggest)
        {
            biggest = c;
        }
        Console.WriteLine(biggest);
    }
}

