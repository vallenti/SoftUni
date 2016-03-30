using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAd
{
    class GenerateAd
    {
        static Random randGen = new Random();
        
        static void Main()
        {
            string[] phrases = new string[]{
                "Excellent product",
                "Thats wonderful product",
                "I always use this product",
                "That's the best product in this category"
            };
            string[] events = new string[]{
                "Now I feel very good",
                "I've changed",
                "This made a miracle",
                "I cant believe but now I feel awesome",
                "Try by yourself. I'm extremely satisfied"
            };
            string[] firstNames = new string[]{
                "Diana", "Petya", "Stella", "Elena", "Katya"
            };
            string[] lastNames = new string[]{
                "Ivanova", "Petrova", "Kirova"
            };
            string[] cities = new string[]{
                "Sofia", "Plovdiv", "Varna", "Burgas"
            };
            int phraseIndex = randGen.Next(0, phrases.Length);
            int eventIndex = randGen.Next(0, events.Length);
            int firstNameIndex = randGen.Next(0, firstNames.Length);
            int lastNameIndex = randGen.Next(0, lastNames.Length);
            int citiesIndex = randGen.Next(0, cities.Length);

            Console.WriteLine(phrases[phraseIndex]+" "+events[eventIndex]+" "+firstNames[firstNameIndex]+" "+lastNames[lastNameIndex]+" "+cities[citiesIndex]);

        }
    }
}
