using System;

class CheckBits
{
    static void Main()
    {
        int v = int.Parse(Console.ReadLine());
        int p = 1;
        int mask = 1 << p;
        Console.WriteLine((v & mask) == 0 ? false : true);

    }
}

