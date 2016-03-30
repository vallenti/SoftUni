using System;

class CalcFactorial2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        long factorial = 1;
        //find n!
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        //find from k to n factorial
        for (int i = (k - n) + 1; i <= k; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}