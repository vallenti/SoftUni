using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.PrintCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cardTypes = new string[] {"Spades","Hearts","Diamonds","Clubs" };
            string[] cards = new string[]{"2","3","4","5","6","7","8","9","10","J","Q","K","A"};
            for (int i = 0; i < cardTypes.Length; i++)
            {
                for (int j = 0; j < cards.Length; j++)
                {
                    Console.WriteLine(cards[j]+" of "+cardTypes[i]);
                }
            }
        }
    }
}
