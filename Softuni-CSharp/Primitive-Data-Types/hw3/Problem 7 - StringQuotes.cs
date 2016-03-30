using System;

class DeclareStringQuotes
{
    static void Main(string[] args)
    {
        string firstVariable = "The \"use\" of quotations causes difficulties.";
        string secondVariable = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(firstVariable);
        Console.WriteLine(secondVariable);
    }
}

