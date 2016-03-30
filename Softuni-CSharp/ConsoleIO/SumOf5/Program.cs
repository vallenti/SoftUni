using System;

class SumOf5
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');
        double sum = 0;
        foreach (string num in numbers)
        {
            sum += double.Parse(num);
        }
        Console.WriteLine(sum);
    }
}

