using System;

    class FibonacciMethod
    {
        static void Main(string[] args)
        {
            long fibonacciNumber = FibN(int.Parse(Console.ReadLine()));
            Console.WriteLine(fibonacciNumber);
        }

        public static long FibN(int n)
        {
            switch (n)
            {
                case 0: return 1;
                case 1: return 1;
                default:
                    long a = 1;
                    long b = 1;
                    long fibNumber = 1;
                    for (int i = 2; i <= n; i++)
                    {
                        fibNumber = a + b;
                        a = b;
                        b = fibNumber;
                    }
                    return fibNumber;
            }
        }
    }

