using System;

class ChangeBits2
{
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
    static void Main()
    {
        int n = 129;
        int pos1 = int.Parse(Console.ReadLine()); //bit position to start 
        int pos2 = int.Parse(Console.ReadLine()); //bit position to start 
        int k = int.Parse(Console.ReadLine()); //how many bits to switch

        //print n at the beginnin in binary
        Console.WriteLine(GetIntBinaryString(n));

        for (int i = 0; i < k; i++)
        {
            int mask1 = 1 << pos1;
            int mask2 = 1 << pos2;
            int bit1 = (n & mask1) == 0 ? bit1 = 0 : bit1 = 1;  //extracts bit at pos1
            int bit2 = (n & mask2) == 0 ? bit2 = 0 : bit2 = 1;  //extracts bit at pos2
            //if bits are different change bit values at pos1 and pos2(0->1 and 1->0)
            if (bit1 != bit2)
            {
                n = (n & mask1) == 0 ? (n | (1 << pos1)) : (n & (~(1 << pos1))); //change bit at pos1
                n = (n & mask2) == 0 ? (n | (1 << pos2)) : (n & (~(1 << pos2))); //change bit at pos2
            }
            pos1++;
            pos2++;
        }

        //print n at the end in binary
        Console.WriteLine(GetIntBinaryString(n));

    }
}

