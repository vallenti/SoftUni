using System;

class CheatSheet
{
    static void Main()
    {
        long rows = long.Parse(Console.ReadLine());
        long cols = long.Parse(Console.ReadLine());
        long v = long.Parse(Console.ReadLine());
        long h = long.Parse(Console.ReadLine());
        long hNull = h;
        long[,] cheatSheet = new long[rows, cols];
        for (int row = 0; row < cheatSheet.GetLength(0); row++)
        {
            for (int col = 0; col < cheatSheet.GetLength(1); col++)
            {
                cheatSheet[row, col] = v * h;

                h++;
            }
            h = hNull;
            v++;
        }
        for (int row = 0; row < cheatSheet.GetLength(0); row++)
        {
            for (int col = 0; col < cheatSheet.GetLength(1); col++)
            {
                Console.Write(cheatSheet[row,col]+" ");
            }
            Console.WriteLine();
        }
        
    }
}

