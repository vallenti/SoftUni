using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintMatix1a
{
    class PrintMatix1a
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            int count = 1;
            int column = 0;
            while(count <= n*n)
            {
                //prints elements down the rows
                for (int row = 0; row < matrix.GetLength(0) ; row++)
                {
                    matrix[row, column] = count;
                    count++;
                }
                column++;
            }
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write(matrix[rows, cols]+"\t");
                }
                Console.WriteLine();
            }
            
        }
    }
}
