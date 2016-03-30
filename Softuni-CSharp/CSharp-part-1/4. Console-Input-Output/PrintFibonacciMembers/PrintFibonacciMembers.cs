using System;
using System.Numerics;

class PrintFibonacciMembers
{
    static void Main()
    {
        BigInteger a = 0;
        BigInteger b = 1;
        BigInteger c = 1;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        for (int i = 3; i<=100 ;i++ )
        {
            a = b;
            b = c;
            c = a + b;
            Console.WriteLine(c);
        }
    }
}