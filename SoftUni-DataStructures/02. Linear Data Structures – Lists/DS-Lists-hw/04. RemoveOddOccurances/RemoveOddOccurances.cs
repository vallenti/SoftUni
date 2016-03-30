namespace _04.RemoveOddOccurances
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RemoveOddOccurances
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> resultSequence = new List<int>(sequence);

            foreach (int currentNumber in sequence)
            {
                int currentNumberCount = sequence.Count(number => number == currentNumber);
                if(currentNumberCount % 2 == 1)
                {
                    resultSequence.RemoveAll(number => number == currentNumber);
                }
            }

            Console.WriteLine(string.Join(" ", resultSequence));
        }
    }
}
