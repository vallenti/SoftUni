using System;

class DeclareNullVar
{
    static void Main()
    {
        int? a = null ;
        double? b = null;
        Console.WriteLine("Integer with null value: "+a);
        Console.WriteLine("Double with null value: "+b);
        a = 5;
        b = 1.432343434254d;
        Console.WriteLine("Integer with not null value: " + a);
        Console.WriteLine("Double with not null value: " + b);
    }
}
