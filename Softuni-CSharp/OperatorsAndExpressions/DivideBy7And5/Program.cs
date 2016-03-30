using System;

class DivideBy7And5
{
    static void Main()
    {
        int num = 35;
        bool isTrue = (num % 7 == 0) && (num % 5 == 0);
        Console.WriteLine(isTrue);
    }
}

