using System;

class CheckDigit
{
    static void Main()
    {
        int num = 123700;
        int hundreds = num / 100;
        bool isSeven = (hundreds % 10) == 7;
        Console.WriteLine(isSeven);
    }
}

