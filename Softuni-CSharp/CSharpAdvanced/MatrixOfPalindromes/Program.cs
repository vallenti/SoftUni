using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        string[] matrixSize = Console.ReadLine().Split(' ');
        int rows = int.Parse(matrixSize[0]);
        int cols = int.Parse(matrixSize[1]);
        char startChar = 'a';
        string[,] matrix = new string[rows, cols];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            char middlleChar = startChar;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(startChar.ToString() + middlleChar.ToString()+ startChar.ToString()+" ");
                middlleChar = (char)(middlleChar + 1);
            }
            middlleChar = (char)(startChar + 1);
            startChar = (char)(startChar + 1);
            Console.WriteLine();
        }
    }
}
