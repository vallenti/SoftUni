using System;

class ExtractBit
{
    static void Main()
    {
        int v = int.Parse(Console.ReadLine());
        int p = 2;
        int mask = 1 << p;
        int bit = (v & mask) == 0 ? bit=0 : bit=1;
        Console.WriteLine(bit);

    }
}

