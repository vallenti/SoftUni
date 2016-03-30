using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string word = Console.ReadLine();

        word = word.ToLower();
        int wordIndex = 0;
        char[,] spiral = new char[n, n];
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
                if (wordIndex == word.Length)
                {
                    wordIndex = 0;
                }
                spiral[rowIndex, i] = word[wordIndex];
                wordIndex++;
                count++;
            }
            rowIndex++;

            //pring down
            for (int i = rowIndex; i <= rowIndexMax; i++)
            {
                if (wordIndex == word.Length)
                {
                    wordIndex = 0;
                }
                spiral[i, colIndexMax] = word[wordIndex];
                wordIndex++;
                count++;
            }
            colIndexMax--;

            //print left
            for (int i = colIndexMax; i >= colIndex; i--)
            {
                if (wordIndex == word.Length)
                {
                    wordIndex = 0;
                }
                spiral[rowIndexMax, i] = word[wordIndex];
                wordIndex++;
                count++;
            }
            rowIndexMax--;

            //print up
            for (int i = rowIndexMax; i >= rowIndex; i--)
            {
                if (wordIndex == word.Length)
                {
                    wordIndex = 0;
                }
                spiral[i, colIndex] = word[wordIndex];
                wordIndex++;
                count++;
            }
            colIndex++;
        }
        int rowWeight = 0;
        int bestRowWeight = 0;
        int bestRowIndex = 0;
        //calculate weight
        for (int row = 0; row < spiral.GetLength(0); row++)
        {
            
            for (int col = 0; col < spiral.GetLength(1); col++)
            {
                rowWeight += ((int)spiral[row, col] - 96) * 10;
            }

            if (rowWeight > bestRowWeight)
            {
                bestRowWeight = rowWeight;
                bestRowIndex = row;
            }
            rowWeight = 0;
        }
        Console.WriteLine("{0} - {1}",bestRowIndex,bestRowWeight);

        
    }
}

