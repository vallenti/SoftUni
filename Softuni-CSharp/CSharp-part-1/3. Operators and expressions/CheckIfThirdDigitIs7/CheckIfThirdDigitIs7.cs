using System;

class CheckIfThirdDigitIs7
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        bool check = (num / 100) % 10 == 7;
        Console.WriteLine(check);
    }
}

