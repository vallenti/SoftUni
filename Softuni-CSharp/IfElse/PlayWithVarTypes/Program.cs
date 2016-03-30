using System;

class PlayWithVarTypes
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
            case 2:
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine(number + 1);
                break;
            case 3:
                string text = Console.ReadLine();
                Console.WriteLine(text+'*');
                break;
            default:
                Console.WriteLine("Input number betwen 1 and 3!");
                break;

        }
    }
}

