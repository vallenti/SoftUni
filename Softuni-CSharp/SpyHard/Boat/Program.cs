using System;

class Boat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dot = '.';
        char star = '*';
        int starCount = 1;
        int dotCount = n - 1;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string(dot,dotCount)+new string(star, starCount)+new string(dot, n));
            if (i < n / 2)
            {
                dotCount -= 2;
                starCount += 2;
            }
            else
            {
                dotCount += 2;
                starCount -= 2;
            }
        }
        starCount = n * 2;
        dotCount = 0;
        for (int i = 0; i < (n-1)/2; i++)
        {
            Console.WriteLine(new string(dot,dotCount)+new string(star, starCount)+new string(dot, dotCount));
            starCount -= 2;
            dotCount++;
        }
    }
}
