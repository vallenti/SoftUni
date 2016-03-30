using System;
using System.Collections.Generic;
using System.Linq;

public class LongestSubesequenceFinder
{
    public static void Main()
    {

    }

    public static List<int> FindLongestSubSeqenceOfEqualNumbers(List<int> sequence)
    {
        var subsequence = new List<int>();
        var bestSubsequence = new List<int>();

        for (int i = 0; i < sequence.Count; i++)
        {
            int currentNumber = sequence[i];
            subsequence.Add(currentNumber);
            for (int j = i + 1; j < sequence.Count; j++)
            {
                if(!(currentNumber == sequence[j]))
                {
                    break;
                }

                subsequence.Add(sequence[j]);             
            }

            if(subsequence.Count > bestSubsequence.Count)
            {
                bestSubsequence.Clear();
                bestSubsequence.AddRange(subsequence);
            }
            subsequence.Clear();
        }

        return bestSubsequence;
    }
}

