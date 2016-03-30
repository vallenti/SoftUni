using System;

class CopyrightTriangle
{
    static void Main()
    {
        string c = "\u00a9";
        string s = "\u0020";
        Console.WriteLine(s+s+c+s+s);
        Console.WriteLine(s+c+c+c+s);
        Console.WriteLine(c+c+c+c+c);
    }
}
//**^**
//*^^^*
//^^^^^
