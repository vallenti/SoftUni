using OOP_DefineClasses;
using System;

class PersonMain
{
    static void Main(string[] args)
    {
        Person p = new Person("Pesho", 10,"a@b.g");
        Person g = new Person("Gosho", 15, null);
        Console.WriteLine(p);
        Console.WriteLine(g);
    }
}

