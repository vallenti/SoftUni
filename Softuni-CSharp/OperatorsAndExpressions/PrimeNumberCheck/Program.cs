using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int num = 61;
        bool isPrime = true;
        for (int i = 2; i < Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
            }
        }
        Console.WriteLine(isPrime);
    }
}

