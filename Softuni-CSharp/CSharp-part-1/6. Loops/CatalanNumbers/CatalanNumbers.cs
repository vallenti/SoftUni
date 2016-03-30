using System;

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long numerator = 1;
        long denominator = 1;
        int n2 = n * 2;
        for (;n+1 < n2;n2--)
        {
            numerator *= n2;
        }
        for (int i = 1; i <= n; i++)
        {
            denominator *= i;
        }
        Console.WriteLine(numerator/denominator);
    }
}
