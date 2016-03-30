using System;

class InputNumbers
{
    static void Main()
    {
        Console.Write("Please choose 0 for integer, 1 for double, 2 for string: ");
        byte n = byte.Parse(Console.ReadLine());
        switch (n)
        {
            case 0:
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine(x + 1);
                break;
            case 1:
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine(y + 1);
                break;
            case 2:
                string z = Console.ReadLine();
                Console.WriteLine(z+"*");
                break;
            default: Console.WriteLine("Invalid data type"); break;
        }
    }
}
