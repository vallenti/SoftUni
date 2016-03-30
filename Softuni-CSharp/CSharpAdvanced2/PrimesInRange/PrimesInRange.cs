using System;
using System.Collections.Generic;

class PrimesInRange
{
    static void Main(string[] args)
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());
        List<int> primeNumbers = FindPrimesInRange(startNum, endNum);
        foreach (int num in primeNumbers)
        {
            Console.Write(num+", ");
        }
    }
    public static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();

        for (int num = startNum; num <= endNum; num++)
        {
            if (IsPrime(num))
            {
                primes.Add(num);
            }
        }

        return primes;
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

