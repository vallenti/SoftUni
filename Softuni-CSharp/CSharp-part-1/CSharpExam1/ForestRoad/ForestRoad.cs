using System;

class ForestRoad
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        for (int i = 1; i <= 2 * n - 1; i++)
        {
            if (i <= n)
            {
                for (int k = 1; k <= n; k++)
                {
                    if (i == k)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                for (int k = 2 * n - 1; k >= n + 1; k--)
                {
                    if (k == i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

