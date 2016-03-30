using System;

class QuadricEquation
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int discr = b * b - 4 * a * c;
        if (discr > 0)
        {
            double x1 = (-b + Math.Sqrt(discr)) / 2 * a;
            double x2 = (-b - Math.Sqrt(discr)) / 2 * a;
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
        else if (discr == 0)
        {
            double x = (-b) / 2 * a;
            Console.WriteLine(x);
        }
        else
        {
            Console.WriteLine("No real roots");
        }
    }
}