using System;

class LongestAreaInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] stringArray = new string[n];
        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] = Console.ReadLine();
        }
        int start = 0; //keeps current index of sequence of equal strings
        int length = 1; // keeps current length of sequence of equal strings
        int bestStart = 0; //index of longest sequence
        int bestLength = 0; //length of longest sequence
        for (int i = 1; i < stringArray.Length; i++)
        {
            if (stringArray[i].Equals(stringArray[i - 1]))
            {
                if (length == 1)
                {
                    start = i - 1;
                }
                length++;
            }
            else
            {
                length = 1;
            }
            if (length > bestLength)
            {
                bestLength = length;
                bestStart = start;
            }
        }
        Console.WriteLine();
        Console.WriteLine(bestLength);
        for (int i = bestStart; i < bestStart+bestLength; i++)
        {
            Console.WriteLine(stringArray[i]);
        }
    }
}

