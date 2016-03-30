using System;

class CheckThirdBit
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int pos = 4;
        int mask = 1 << pos;
        int nAndMask = num & mask;
        int bit = nAndMask >> pos;
        Console.WriteLine(bit);
    }
}
