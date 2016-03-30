using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        List<string> firstListString = new List<string>(Console.ReadLine().Split(' '));
        List<string> secondListString = new List<string>(Console.ReadLine().Split(' '));
        List<int> firstListInt = new List<int>();
        List<int> secondListInt = new List<int>();

        //convert string list to int list
        foreach (string num in firstListString)
        {
            firstListInt.Add(int.Parse(num));
        }
        foreach (string num in secondListString)
        {
            secondListInt.Add(int.Parse(num));
        }

        //remove duplicates in the lists
        firstListInt = firstListInt.Distinct().ToList<int>();
        secondListInt = secondListInt.Distinct().ToList<int>();

        //join 2 lists
        for (int i = 0; i < secondListInt.Count; i++)
        {
            if (!firstListInt.Contains(secondListInt[i]))
            {
                firstListInt.Add(secondListInt[i]);
            }
        }

        //sort and print joined list
        firstListInt.Sort();
        foreach (var num in firstListInt)
        {
            Console.Write(num+" ");
        }
    }
}

