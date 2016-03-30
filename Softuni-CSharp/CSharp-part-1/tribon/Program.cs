using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        BigInteger a = BigInteger.Parse(Console.ReadLine());
        BigInteger b = BigInteger.Parse(Console.ReadLine());
        BigInteger c = BigInteger.Parse(Console.ReadLine());
        BigInteger d = 0;

        uint n = uint.Parse(Console.ReadLine());
        if (n < 4)
        {
            switch (n)
            {
                case 1: Console.WriteLine(a); break;
                case 2: Console.WriteLine(b); break;
                case 3: Console.WriteLine(c); break;
            }
        }
        else
        {
            for (int i = 4; i <= n; i++)
            {
                d = a + b + c;
                a = b;
                b = c;
                c = d;
            }
        }
        Console.WriteLine(d);
    }
}