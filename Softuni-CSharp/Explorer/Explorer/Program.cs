using System;

class TheExplorer
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int height = width;
        string star = "*";
        string dash = "-";
        int lowerNumber = width / 2;
        int upperNumber = width / 2;

        for (int i = 0; i < width; i++)
		{
			for (int j = 0; j < height; j++)
		    {
                if (i == 0 && j == lowerNumber)
                {
                    Console.Write(star);
                }
                else if(i>0 && j==lowerNumber)
                {
                    Console.Write(star);
                }
                else if (i > 0 && j == upperNumber)
                {
                    Console.Write(star);
                }
                else
                {
                    Console.Write(dash);
                }
		    }
            if (i < width / 2)
            {
                lowerNumber--;
                upperNumber++;
            }
            else
            {
                lowerNumber++;
                upperNumber--;
            }
            Console.WriteLine();
		}
     }
}


