using System;

class Sort3Numbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double min = 0;
        double middle = 0;
        double max = 0;
        if (a > b)
        {
            max = a;
            min = b;
            if (c > max)
            {
                max = c;
                middle = a;
            }
            else if (c < min)
            {
                min = c;
                middle = b;
            }
            else
            {
                middle = c;
            }
        }
        else
        {
            max = b;
            min = a;
            if (c > max)
            {
                max = c;
                middle = b;
            }
            else if (c < min)
            {
                min = c;
                middle = a;
            }
            else
            {
                middle = c;
            }
        }
        Console.WriteLine(max+" "+middle+" "+min);

    }
}

