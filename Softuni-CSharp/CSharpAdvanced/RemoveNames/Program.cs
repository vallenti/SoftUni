using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        List<string> firstList = new List<string>(Console.ReadLine().Split(' '));
        List<string> secondList = new List<string>(Console.ReadLine().Split(' '));
        List<string> intersect = new List<string>();

        for (int i = 0; i < firstList.Count; i++)
        {
            if(!secondList.Contains(firstList[i]))
            {
                intersect.Add(firstList[i]);
            }
        }

        foreach (string name in intersect)
        {
            Console.Write(name+" ");
        }
        Console.WriteLine();
    }
}
