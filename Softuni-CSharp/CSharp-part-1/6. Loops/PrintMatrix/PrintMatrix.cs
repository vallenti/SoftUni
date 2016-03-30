using System;

class PrintMatrix
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        if (n >= 20)
        {
            Console.WriteLine("Please enter valid number!");
        }
        else
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col <= ((row + n) - 1); col++)
                {
                    Console.Write(col+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
