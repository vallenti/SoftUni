using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FindTheRoot
{
    public class FindRootInGraph
    {
        static void Main(string[] args)
        {
            int nodesCount = int.Parse(Console.ReadLine());
            int edgesCount = int.Parse(Console.ReadLine());
            bool[] hasParent = new bool[nodesCount];
            for (int i = 0; i < edgesCount; i++)
            {
                int[] nodePair = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                int fromNode = nodePair[0];
                int toNode = nodePair[1];

                hasParent[toNode] = true;
            }

            List<int> rootNodes = new List<int>();
            for (int i = 0; i < hasParent.Length; i++)
            {
                if(!hasParent[i])
                {
                    rootNodes.Add(i);
                }
            }

            if(rootNodes.Count == 0)
            {
                Console.WriteLine("No root!");
            }
            else if(rootNodes.Count == 1)
            {
                Console.WriteLine(rootNodes[0]);
            }
            else
            {
                Console.WriteLine("Multiple root nodes!");
            }
        }
    }
}
