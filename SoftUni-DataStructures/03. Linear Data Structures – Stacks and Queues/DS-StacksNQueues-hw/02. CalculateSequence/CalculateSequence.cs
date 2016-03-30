using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CalculateSequence
{
    public class CalculateSequence
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> sequence = new Queue<int>();
            List<int> fullSequence = new List<int>();
            sequence.Enqueue(n);
            fullSequence.Add(n);
            for (int i = 0; i < 49; i++)
            {
                int s1 = sequence.Dequeue();
                int s2 = s1 + 1;
                int s3 = 2 * s1 + 1;
                int s4 = s1 + 2;

                sequence.Enqueue(s2);
                sequence.Enqueue(s3);
                sequence.Enqueue(s4);

                fullSequence.Add(s1);
            }

            Console.WriteLine(string.Join(", ", fullSequence));
        }
    }
}
