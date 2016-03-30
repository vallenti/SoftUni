using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
    class PasswordGenerator
    {
        private const int MinCapitalLetters = 2;
        private const int MinSmallLetters = 2;
        private const int MinDigits = 1;
        private const int MinSpecialChars = 3;
        private const int MaxPasswordLength = 15;
        private const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SmallLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string Digits = "0123456789";
        private const string SpecialChars = "~!@#$%^&*()_+=`{}[]\\|':;.,/?<>";
        private const string AllChars = CapitalLetters + SmallLetters + Digits + SpecialChars;
        private static Random randGen = new Random();

        private static char GenerateChar(string availableChars)
        {
            int randomIndex = randGen.Next(availableChars.Length);
            char randomChar = availableChars[randomIndex];
            return randomChar;
        }
        private static void InsertAtRandomPosition(StringBuilder password, char character)
        {
            int randomPosition = randGen.Next(password.Length + 1);
            password.Insert(randomPosition, character);
        }

        static void Main()
        {
            StringBuilder password = new StringBuilder();

            //generate capital letters in password
            for (int i = 1; i <= MinCapitalLetters; i++)
            {
                char capitalLetter = GenerateChar(CapitalLetters);
                InsertAtRandomPosition(password, capitalLetter);
            }

            //generate small letters in password
            for (int i = 1; i <= MinSmallLetters; i++)
            {
                char smallLetter = GenerateChar(SmallLetters);
                InsertAtRandomPosition(password, smallLetter);
            }

            //generate 1 digit in password
            for (int i = 1; i <= MinDigits; i++)
            {
                char digit = GenerateChar(Digits);
                InsertAtRandomPosition(password, digit);
            } 

            //generate special character
            for (int i = 1; i <= MinSpecialChars ; i++)
            {
                char specialChar = GenerateChar(SpecialChars);
                InsertAtRandomPosition(password, specialChar);
            }

            //generate random symbols
            int maxAdditionalChars = MaxPasswordLength - password.Length;
            int additionalCharsCount = randGen.Next(maxAdditionalChars+1);
            for (int i = 0; i <= additionalCharsCount; i++)
            {
                char randomChar = GenerateChar(AllChars);
                InsertAtRandomPosition(password, randomChar);
            }

            Console.WriteLine(password);
        }
    }
}
