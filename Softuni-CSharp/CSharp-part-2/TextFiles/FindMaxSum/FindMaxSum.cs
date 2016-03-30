using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxSum
{
    class FindMaxSum
    {
        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            string file = "matrix.txt";
            int sum = 0;
            int bestSum = 0;
            try
            {
                StreamReader reader = new StreamReader(file);
                using (reader)
                {
                    int size = int.Parse(reader.ReadLine());
                    int[,] matrix = new int[size, size];
                    for (int row = 0; row < matrix.GetLength(0); row++)
			        {
                        string[] line = reader.ReadLine().Split(' ');
			            for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            matrix[row, col] = int.Parse(line[col]);
                        }
			        }
                   // PrintMatrix(matrix);
                    for (int row = 0; row < matrix.GetLength(0)-1; row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1)-1; col++)
                        {
                            sum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                            if (row == 0 && col == 0) bestSum = sum;
                            if (sum > bestSum) bestSum = sum;
                        }
                    }
                    Console.WriteLine(bestSum);
                }
            }
            catch (FileNotFoundException)
            {

            }
        }    
    }
}
