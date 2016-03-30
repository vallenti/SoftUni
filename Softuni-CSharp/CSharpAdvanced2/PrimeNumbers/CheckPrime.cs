using System;

class CheckPrimeNumber
{
    static void Main()
    {
        Console.WriteLine(IsPrime(long.Parse(Console.ReadLine())));
    }

    public static bool IsPrime(long num)
    {
        int divider = 2;
        int maxDivider = (int)Math.Sqrt(num);
        bool isPrime = true;
        while (isPrime && (divider <= maxDivider))
        {
            if (num % divider == 0)
            {
                return false;
            }
            divider++;
        }
        return true;
    }
}
