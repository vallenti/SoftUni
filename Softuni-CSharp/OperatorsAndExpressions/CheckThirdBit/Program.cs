using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int pos = int.Parse(Console.ReadLine());
        int mask = 1 << pos;
        int nAndMask = num & mask;
        int bit = nAndMask >> pos;
        Console.WriteLine(bit);
        Console.WriteLine(GetIntBinaryString(num));
    }
    static string GetIntBinaryString(int n)
    {
        char[] b = new char[32];
        int pos = 31;
        int i = 0;

        while (i < 32)
        {
            if ((n & (1 << i)) != 0)
            {
                b[pos] = '1';
            }
            else
            {
                b[pos] = '0';
            }
            pos--;
            i++;
        }
        return new string(b);
    }
}

