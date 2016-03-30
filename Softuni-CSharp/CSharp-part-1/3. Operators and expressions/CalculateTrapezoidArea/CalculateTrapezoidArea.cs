using System;

class CalculateTrapezoidArea
{
    static void Main()
    {
        uint a = uint.Parse(Console.ReadLine());
        uint b = uint.Parse(Console.ReadLine());
        uint h = uint.Parse(Console.ReadLine());

        Console.WriteLine(((a+b)/2)*h);
    }
}

