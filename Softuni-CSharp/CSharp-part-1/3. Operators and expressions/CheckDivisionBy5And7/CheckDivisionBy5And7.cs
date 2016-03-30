using System;

class CheckDivisionBy5And7
{
    static void Main()
    {
        int i = int.Parse(Console.ReadLine());
        bool check = (i % 5 == 0) && (i % 7 == 0);
        Console.WriteLine(check);
    }
}

