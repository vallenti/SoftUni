using System;

class PrintIsoscaleTriangle
{
    static void Main()
    {
        char copy = '\u00a9';
        char space = ' ';
        Console.WriteLine("{0}{0}{0}{1}{0}{0}{0}", space, copy);
        Console.WriteLine("{0}{0}{1}{0}{1}{0}{0}", space, copy);
        Console.WriteLine("{0}{1}{0}{0}{0}{1}{0}", space, copy);
        Console.WriteLine("{1}{0}{1}{0}{1}{0}{1}", space, copy);
    }
}

