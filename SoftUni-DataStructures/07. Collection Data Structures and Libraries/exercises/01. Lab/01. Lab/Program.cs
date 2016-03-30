using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _01.Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var events = new OrderedMultiDictionary<DateTime, string>(true);
            int numberOfEvents = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfEvents; i++)
            {
                string eventEntry = Console.ReadLine();
                var eventTokens = eventEntry.Split('|');
                string eventName = eventTokens[0];
                DateTime eventDate = DateTime.Parse(eventTokens[1].Trim());
                events.Add(eventDate, eventName);
            }
            int requestDatesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < requestDatesCount; i++)
            {
                string requestEntry = Console.ReadLine();
                var requestTokens = requestEntry.Split('|');
                DateTime startDate = DateTime.Parse(requestTokens[0].Trim());
                DateTime endDate = DateTime.Parse(requestTokens[1].Trim());
                var eventsInRange = events.Range(startDate, true, endDate, true);
                Console.WriteLine(eventsInRange.Count);
                foreach (var ev in eventsInRange)
                {
                    Console.WriteLine(ev.Value + "|" + ev.Key);
                }
            }
        }
    }
}
