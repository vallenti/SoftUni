using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PlayWithTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            int nodesCount = int.Parse(Console.ReadLine());
            for (int i = 1; i < nodesCount; i++)
            {
                string[] edge = Console.ReadLine().Split();
                int parentValue = int.Parse(edge[0]);
                Tree<int> parentNode = Tree<int>.GetTreeNodeByValue(parentValue);
                int childValue = int.Parse(edge[1]);
                Tree<int> childNode = Tree<int>.GetTreeNodeByValue(childValue);
                parentNode.Children.Add(childNode);
                childNode.Parent = parentNode;
            }
            
            int pathSum = int.Parse(Console.ReadLine());
            int subtreeSum = int.Parse(Console.ReadLine());

            Console.WriteLine("Root node: " + Tree<int>.FindRootNode());
            Console.WriteLine("Leaf nodes: "+ string.Join(", ", Tree<int>.FindLeafNodes()));
            Console.WriteLine("Middle nodes: "+ string.Join(", ", Tree<int>.FindMiddleNodes()));
            Console.WriteLine("Longest path: {0} (length = {1})", string.Join(" -> ",Tree<int>.FindLongestPath()), Tree<int>.FindLongestPath().Count());
            Console.WriteLine("Paths of sum {0}:", pathSum);
            foreach (var item in Tree<int>.FindAllPathsOfSum(pathSum))
            {
                Console.WriteLine(string.Join(" -> ", item));
            }
            Console.WriteLine("Subtrees of sum {0}:",subtreeSum);
            Tree<int>.SubtreeSums(subtreeSum);

        }

        
    }
}
