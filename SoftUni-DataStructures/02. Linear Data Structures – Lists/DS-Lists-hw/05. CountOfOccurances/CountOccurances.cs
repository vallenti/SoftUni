namespace _05.CountOfOccurances
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CountOccurances
    {
        public static void Main()
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] occurancesArray = CountOccurancesArray(sequence);
            IDictionary<int, int> occurancesDictionary = CountOccurancesDictionary(sequence);

            for (int index = 0; index < occurancesArray.Length; index++)
            {
                if(occurancesArray[index] != 0)
                {
                    Console.WriteLine("{0} -> {1} times", index, occurancesArray[index]);
                }
            }

            Console.WriteLine("---------------");

            foreach (var item in occurancesDictionary)
            {
                Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
            }

        }

        public static int[] CountOccurancesArray(IList<int> sequence)
        {
            var result = new int[1001];
            foreach (var number in sequence)
            {
                result[number]++;
            }
            return result;
        }

        public static IDictionary<int, int> CountOccurancesDictionary(IList<int> sequence)
        {
            var result = new SortedDictionary<int, int>();
            foreach (var number in sequence)
            {
                if(!result.ContainsKey(number))
                {
                    result.Add(number, 0);
                }

                result[number]++;
            }

            return result;
        }
    }
}
