using System;

class FibonacciNumbers
{
    static void Main()
    {
        int a = 0;
        int b = 1;
        int c = 1;
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            Console.WriteLine(a);
        }
        else if (n == 2)
        {
            Console.WriteLine(b);
        }
        else if (n == 3)
        {
            Console.WriteLine(c);
        }
        else
        {
            for (int i = 4; i <= n; i++)
            {
                a = b;
                b = c;
                c = a + b;
            }
            Console.WriteLine(c);
        }
    }
}
