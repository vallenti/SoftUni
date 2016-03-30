using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int oddSum = 0;
        int evenSum = 0;
        for (int i = 1; i <= n*2; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (i % 2 == 1)
            {
                oddSum += num;
            }
            else
            {
                evenSum += num;
            }
        }
        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes, sum={0}", oddSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}",Math.Abs(oddSum-evenSum));
        }
    }
}

