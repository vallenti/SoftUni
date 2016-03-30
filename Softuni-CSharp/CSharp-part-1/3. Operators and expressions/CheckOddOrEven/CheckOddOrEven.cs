using System;

class CheckOddOrEven
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        bool isEven = num % 2 == 0;
        Console.WriteLine(isEven);
    }
}

