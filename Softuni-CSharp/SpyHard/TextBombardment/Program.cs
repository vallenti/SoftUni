using System;
using System.Text;

class TextBombardment
{
    static void Main()
    {
        string line = Console.ReadLine();
        int lineWidth = int.Parse(Console.ReadLine());
        string[] stringBombs = Console.ReadLine().Split(' ');
        int[] bombs = new int[stringBombs.Length];
        for (int i = 0; i < bombs.Length; i++)
        {
            bombs[i] = int.Parse(stringBombs[i]);
        }
        Console.WriteLine();
        int rows = (int)(Math.Ceiling((double)line.Length / lineWidth));
        string[,] text = new string[rows, lineWidth];
        int textIndex = 0;
        for (int row = 0; row < text.GetLength(0); row++)
        {
            for (int col = 0; col < text.GetLength(1); col++)
            {
                if (textIndex < line.Length)
                {
                    text[row, col] = line[textIndex].ToString();
                    textIndex++;
                }
                else
                {
                    text[row, col] = "";
                }
            }
        }
        for (int i = 0; i < bombs.Length; i++)
        {
            int bombCol = bombs[i];
            bool hit = false;
            for (int row = 0; row < text.GetLength(0); row++)
            {

                    if ((text[row, bombCol] == "" || text[row, bombCol] == " ") &&  hit == true)
                    {
                        break;
                    }
                    else
                    {
                        text[row, bombCol] = " ";
                        hit = true;
                    }
               
            }
        }
        StringBuilder result = new StringBuilder();
        for (int row = 0; row < text.GetLength(0); row++)
        {
            for (int col = 0; col < text.GetLength(1); col++)
            {
                result.Append(text[row, col]);
            }
        }
        Console.WriteLine(result);
       
    }
}

