using System;

class Headphones
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        int width = height * 2 + 1;
        char star = '*';
        char dash = '-';
        string firstLine = new string(dash, height / 2) + new string(star, width-((height/2)*2))+new string(dash, height / 2);
        string secondLine = new string(dash, height / 2) + star + new string(dash, width-((height/2)*2)-2) + star + new string(dash, height / 2);
        Console.WriteLine(firstLine);
        for (int i = 0; i < height-1; i++)
        {
            Console.WriteLine(secondLine);
        }
        int starCount = 1;
        int space = height / 2;
        for (int i = 0; i <= height/2; i++)
        {
            string line = new string(dash, space) + new string(star, starCount) + new string(dash, space);
            Console.WriteLine(line+'-'+line);
            space -= 1;
            starCount += 2;
        }
        starCount -= 2;
        space += 1;
        for (int i = 0; i <height/2; i++)
        {
            starCount -= 2;
            space += 1;
            string line = new string(dash, space) + new string(star, starCount) + new string(dash, space);
            Console.WriteLine(line+'-'+line);
        }

    }
}
