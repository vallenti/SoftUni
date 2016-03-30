using System;

class FindSmallerAndBiggerNumber
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Smaller number: " + Math.Min(a, b));
        Console.WriteLine("Greater number: " + Math.Max(a, b));

    }
}
