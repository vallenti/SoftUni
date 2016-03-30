using System;

class ChangeNumber
{
    static void Main()
    {
        int n = 0;
        int v = 1;
        int p = 9;
        int mask = 1 << p;
        n = (n & mask) == 0 ? (n | (1 << p)) : (n & (~(1 << p)));
        Console.WriteLine(n);
    }
}

