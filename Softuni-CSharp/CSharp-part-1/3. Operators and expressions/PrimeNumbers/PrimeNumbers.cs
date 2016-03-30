using System;

class PrimeNumbers
{
    static void Main()
    {
        uint num = uint.Parse(Console.ReadLine());
        if (num > 100)
        {
            Console.WriteLine("Invalid number!");
        }
        else
        {

            bool prime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                }
            }
            Console.WriteLine(prime);
        }
    }
}

