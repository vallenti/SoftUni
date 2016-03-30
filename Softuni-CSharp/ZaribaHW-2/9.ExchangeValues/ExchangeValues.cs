using System;

class ExchangeValues
{
    static void Main()
    {
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());

        Console.WriteLine("First: {0} | Second: {1}", numberOne, numberTwo);

        int tempNumber = numberOne;
        numberOne = numberTwo;
        numberTwo = tempNumber;

        Console.WriteLine("First: {0} | Second: {1}",numberOne,numberTwo);
    }
}
