using System;

class CompareFloats
{
    static void Main()
    {
        double eps = 0.000001;
        double a = -4.999999;
        double b = -4.999998;
        if (Math.Abs(a - b) < eps)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

