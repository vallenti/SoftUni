using System;

class CountTrailingZeros
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        long sum = 0;
        for (int i = 5; i < n; i *= 5)
        {
            sum += n / i;
        }
        Console.WriteLine(sum);
    }
}
