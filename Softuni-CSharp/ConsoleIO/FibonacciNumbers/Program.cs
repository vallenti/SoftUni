using System;

class PrintFibonacciSequence
{
    static void Main(string[] args)
    {
        int n = 0;
        do{
            n = int.Parse(Console.ReadLine());
        } while (n < 0);

        int a = 0;
        int b = 1;
        if (n == 1)
        {
            Console.WriteLine(a);
        }
        else if (n == 2)
        {
            Console.WriteLine("{0} {1}", a, b);
        }
        else
        {
            Console.Write("{0} {1} ", a, b);
            for (int i = 2; i < n; i++)
            {
                int c = a + b;
                Console.Write("{0} ", c);
                a = b;
                b = c;
            }
        }
    }
}

