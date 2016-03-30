using System;

class DeclareStringandObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object obj = hello + " " + world;
        string helloWorld = (string)obj;
        Console.WriteLine(helloWorld);
    }
}

