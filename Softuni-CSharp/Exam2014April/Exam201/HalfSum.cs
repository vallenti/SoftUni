using System;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int[] b = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            b[i] = int.Parse(Console.ReadLine());
        }
        int sumA = 0;
        int sumB = 0;
        for (int i = 0; i < n; i++)
        {
            sumA += a[i];
            sumB += b[i];
        }
        if (sumA == sumB)
        {
            Console.WriteLine("Yes, sum={0}", sumA);
        }
        else
        {
            Console.WriteLine("No, diff={0}",Math.Abs(sumA-sumB));
        }
    }
}
