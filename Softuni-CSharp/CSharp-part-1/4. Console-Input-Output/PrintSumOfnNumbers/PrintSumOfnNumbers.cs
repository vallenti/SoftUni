using System;

class PrintSumOfnNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            sum += x;
        }
        Console.WriteLine(sum);
    }
}

