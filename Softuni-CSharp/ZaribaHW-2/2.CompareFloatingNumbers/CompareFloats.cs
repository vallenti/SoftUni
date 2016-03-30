using System;

class CompareFloats
{
    static void Main()
    {
        float numberOne = float.Parse(Console.ReadLine());
        float numberTwo = float.Parse(Console.ReadLine());
        float eps = 0.00001f;
        if (Math.Abs(numberOne - numberTwo) <= eps)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

