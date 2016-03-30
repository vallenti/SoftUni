using System;

class PaintBall
{
    static void Main()
    {
        int[,] matrix = new int[10, 10];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = 1;
            }
        }
        string line;
        bool isBlack = true;
        while((line=Console.ReadLine()) != null)
        {
            if (line == "End")
            {
                break;
            }
            int hit;
            if (isBlack)
            {
                hit = 1;
            }
            else
            {
                hit = 0;
            }
            string[] coords = line.Split(' ');
            int x = int.Parse(coords[0]);
            int y = int.Parse(coords[1]);
            switch (y)
            {
                case 9: y = 0; break;
                case 8: y = 1; break;
                case 7: y = 2; break;
                case 6: y = 3; break;
                case 5: y = 4; break;
                case 4: y = 5; break;
                case 3: y = 6; break;
                case 2: y = 7; break;
                case 1: y = 8; break;
                case 0: y = 9; break;
            }
            int r = int.Parse(coords[2]);

            int up = x-r;
            int down = x+r;
            if (up < 0)
            {
                up = 0;
            }
            if (down > 9)
            {
                down = 9;
            }
            int left = y - r;
            int right = y + r;
            if (left < 0)
            {
                left = 0;
            }
            if (right > 9)
            {
                right = 9;
            }
            if (isBlack)
            {
                for (int row = up; row <= down; row++)
                {

                    for (int col = left; col <= right; col++)
                    {
                        matrix[row, col] = 0;
                    }
                }
            }
            else
            {
                for (int row = up; row <= down; row++)
                {

                    for (int col = left; col <= right; col++)
                    {
                        matrix[row, col] = 1;
                    }
                }
            }
            isBlack = !isBlack;
        }

        string binaryNumber = "";
        long sum = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                binaryNumber += matrix[row, col];   
            }
            int decimalNumber = Convert.ToInt32(binaryNumber,2);
            sum += decimalNumber;
            binaryNumber = "";
            
        }
        Console.WriteLine(sum);

        ////print
        //for (int row = 0; row < matrix.GetLength(0); row++)
        //{
        //    for (int col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        Console.Write(matrix[row, col] + " ");
        //    }
        //    Console.WriteLine();
        //}
    }
}

