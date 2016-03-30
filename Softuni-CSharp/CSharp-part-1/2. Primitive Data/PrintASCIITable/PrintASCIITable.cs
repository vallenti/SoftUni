using System;

class PrintASCIITable
{
    static void Main()
    {
        for (int i = 0; i < 128; i++)
        {
            char symbol = (char)i;
            Console.WriteLine(symbol);
        }
    }
}

