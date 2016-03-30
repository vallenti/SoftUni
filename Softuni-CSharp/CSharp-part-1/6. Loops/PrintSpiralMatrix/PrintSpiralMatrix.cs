using System;

class PrintSpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n >= 20)
        {
            Console.WriteLine("Please input valid number!");
        }
        else
        {
            int[,] spiral = new int[n,n];
            int rowIndex = 0;
            int colIndex = 0;
            int rowIndexMax = n - 1;
            int colIndexMax = n - 1;
            int count = 1;
            while (count <= n * n)
            {
                //print right
                for (int i = colIndex; i <= colIndexMax; i++)
                {
                    spiral[rowIndex, i] = count;                               
                    count++;
                }
                rowIndex++;

                //pring down
                for (int i = rowIndex; i <= rowIndexMax; i++)
                {
                    spiral[i, colIndexMax] = count;                            
                    count++;
                }
                colIndexMax--;

                //print left
                for (int i = colIndexMax; i >= colIndex; i--)
                {
                    spiral[rowIndexMax, i] = count;                             
                    count++;
                }
                rowIndexMax--;
                
                //print up
                for (int i = rowIndexMax; i >= rowIndex; i--)
                {
                    spiral[i, colIndex] = count;                              
                    count++;
                }
                colIndex++;
            }
            for (int row = 0; row < spiral.GetLength(0); row++)
            {
                for (int col = 0; col < spiral.GetLength(1); col++)
                {
                    Console.Write(spiral[row, col]+"\t");
                }
                Console.WriteLine();
            }
        }
        
    }
}

