using System;

class HelloWorld
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object hw = hello + " " + world;
        string thirdString = (string)hw;
        Console.WriteLine(thirdString);
    }
}

