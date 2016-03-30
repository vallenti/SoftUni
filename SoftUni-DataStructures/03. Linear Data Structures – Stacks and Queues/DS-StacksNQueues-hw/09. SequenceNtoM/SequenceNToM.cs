using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SequenceNtoM
{
    public class SequenceNToM
    {
        public static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startNumber = inputNumbers[0]; 
            int targetNumber = inputNumbers[1];

            Queue<SequenceItem<int>> sequence = new Queue<SequenceItem<int>>();
            Stack<int> shortestSequenceOfOperations = new Stack<int>();

            sequence.Enqueue(new SequenceItem<int>(startNumber));

            while (sequence.Count > 0)
            {
                SequenceItem<int> currentItem = sequence.Dequeue();
                if(currentItem.Value < targetNumber)
                {
                    sequence.Enqueue(new SequenceItem<int>(currentItem.Value + 1, currentItem));
                    sequence.Enqueue(new SequenceItem<int>(currentItem.Value + 2, currentItem));
                    sequence.Enqueue(new SequenceItem<int>(currentItem.Value * 2, currentItem));
                }

                if(currentItem.Value == targetNumber)
                {
                    while(currentItem != null)
                    {
                        shortestSequenceOfOperations.Push(currentItem.Value);
                        currentItem = currentItem.PreviousItem;
                    }
                    break;
                }
            }

            Console.WriteLine(string.Join(" -> ", shortestSequenceOfOperations.ToArray()));
        }   
    }
}
