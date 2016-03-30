using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LongestNonDecreasingSubsequence
{
    static void Main()
    {
        //string[] input = new string[] { "11", "12", "13", "3", "14", "4", "15", "5", "6", "7", "8", "7", "16", "9", "8" };
        //string[] input = new string[] { "1", "1", "1", "3", "3", "3", "2", "2", "2", "2" };
        string[] input = new string[] { "1", "1", "1", "2", "2", "2" };
        int[] array = new int[input.Length];
        List<int> output = new List<int>();
        int biggestNumber = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(input[i]);
        }
        for (int i = 0; i < array.Length-1; i++)
        {
            if (biggestNumber < array[i])
            {
                biggestNumber = array[i];
            }
            if (array[i + 1] < biggestNumber)
            {
                output.Add(array[i + 1]);
            }
        }
        Console.WriteLine(biggestNumber);
        foreach (var num in output)
        {
            Console.Write(num + " ");
        }
    }
}

