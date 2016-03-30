using System;

class ModifyBit
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int pos = int.Parse(Console.ReadLine());
        int mask = 1 << pos;
        num = (num & mask) == 0 ? (num | (1 << pos)) : (num & (~(1 << pos)));
        Console.WriteLine(num);
    }
}

