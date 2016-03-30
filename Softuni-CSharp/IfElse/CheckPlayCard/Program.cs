using System;


class CheckPlayCard
{
    static void Main()
    {
        string card = Console.ReadLine();
        int number;
        if (card == "Q" || card == "K" || card == "J" || card == "A")
        {
            Console.WriteLine("yes");
        }
        else if (int.TryParse(card, out number))
        {
            if (number > 1 && number < 11)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        else
        {
            Console.WriteLine("no");
        }
       
    }
}

