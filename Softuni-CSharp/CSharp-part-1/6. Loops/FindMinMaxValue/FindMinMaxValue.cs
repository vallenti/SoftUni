using System;

class FindMinMaxValue
{
    static void Main()
    {
        bool flag = true;
        int min=0, max=0;
        int n = int.Parse(Console.ReadLine());
        for(int i = 0;i<n;i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (flag)
            {
                min = x;
                max = x;
                flag = false;
            }
            else
            {
                if (x > max) max = x;
                if (x < min) min = x;
            }
        }
        Console.WriteLine(min);
        Console.WriteLine(max);
    }
}
