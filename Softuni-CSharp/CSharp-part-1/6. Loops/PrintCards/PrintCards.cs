using System;

class PrintCards
{
    static void Main()
    {
        for (int suit = 1; suit < 5; suit++)
        {
            for (int rank = 1; rank < 14; rank++)
            {
                switch (rank)
                {
                    case 1: Console.Write("Ace "); break;
                    case 2: Console.Write("Two "); break;
                    case 3: Console.Write("Three "); break;
                    case 4: Console.Write("Four "); break;
                    case 5: Console.Write("Five "); break;
                    case 6: Console.Write("Six "); break;
                    case 7: Console.Write("Seven "); break;
                    case 8: Console.Write("Eight "); break;
                    case 9: Console.Write("Nine "); break;
                    case 10: Console.Write("Ten "); break;
                    case 11: Console.Write("Jack "); break;
                    case 12: Console.Write("Queen "); break;
                    case 13: Console.Write("King "); break;
                }
                switch (suit)
                {
                    case 1: Console.WriteLine("of diamonds"); break;
                    case 2: Console.WriteLine("of hearts"); break;
                    case 3: Console.WriteLine("of spades"); break;
                    case 4: Console.WriteLine("of clubs"); break;
                }
            }
        }
    }
}

