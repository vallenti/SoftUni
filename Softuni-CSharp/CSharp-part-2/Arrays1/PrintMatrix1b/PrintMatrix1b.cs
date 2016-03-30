using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintMatrix1b
{
    class PrintMatrix1b
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int count = 1;
            int column = 0;
            while (count <= n * n)
            {
                //fill elements down the rows
                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    matrix[rows, column] = count;
                    count++;
                }
                column++;

                //check if column index is in matrix boundaries (case if "int n" is odd number)
                if (column <= n - 1)
                {
                    //fill elements up the rows
                    for (int rows = matrix.GetLength(0) - 1; 0 <= rows; rows--)
                    {
                        matrix[rows, column] = count;
                        count++;
                    }
                    column++;
                }
                
            }
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write(matrix[rows,cols]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
