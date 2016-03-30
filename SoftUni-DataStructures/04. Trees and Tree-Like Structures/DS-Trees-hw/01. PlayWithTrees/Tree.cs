using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PlayWithTrees
{
    public class Tree<T>
    {
        public static Dictionary<T, Tree<T>> nodeByValue = new Dictionary<T, Tree<T>>();

        public Tree(T value, params Tree<T>[] children)
        {
            this.Value = value;
            this.Children = new List<Tree<T>>();
            foreach (var child in children)
            {
                this.Children.Add(child);
                child.Parent = this;
            }
        }

        public T Value { get; set; }
        public Tree<T> Parent { get; set; }
        public IList<Tree<T>> Children { get; set; }

        public static Tree<T> GetTreeNodeByValue(T value)
        {
            if(!nodeByValue.ContainsKey(value))
            {
                nodeByValue[value] = new Tree<T>(value);
            }

            return nodeByValue[value];
        }

        public static Tree<T> FindRootNode()
        {
            var rootNode = nodeByValue.Values.FirstOrDefault(node => node.Parent == null);

            return rootNode;
        }

        public static IEnumerable<Tree<T>> FindMiddleNodes()
        {
            var middleNodes = nodeByValue.Values
                .Where(node => node.Children.Count > 0 & node.Parent != null)
                .OrderBy(node => node.Value)
                .ToList();

            return middleNodes;
        }

        public static IEnumerable<Tree<T>> FindLeafNodes()
        {
            var leafNodes = nodeByValue.Values
                .Where(node => node.Children.Count == 0)
                .OrderBy(node => node.Value)
                .ToList();

            return leafNodes;
        }

        public static IEnumerable<Tree<T>> FindLongestPath()
        {
            int maxDepth = 0;
            var startNode = FindRootNode();
            Stack<Tree<T>> stack = new Stack<Tree<T>>();
            Tree<T>[] longestPath = new Tree<T>[] { };
            Stack<Tree<T>> tempPath = new Stack<Tree<T>>();
            stack.Push(startNode);
            while(stack.Count > 0)
            {
                var currentNode = stack.Pop();
                if(currentNode.Children.Count == 0)
                {
                    var node = currentNode;
                    while (null != node)
                    {
                        tempPath.Push(node);
                        node = node.Parent;

                    }

                    if (tempPath.Count >= maxDepth)
                    {
                        maxDepth = tempPath.Count;
                        longestPath = tempPath.ToArray();
                    }
                }

                tempPath.Clear();

                foreach (var child in currentNode.Children)
                {
                    stack.Push(child); 
                }
            }
            return longestPath;
        }

        public static IEnumerable<Tree<int>>[] FindAllPathsOfSum(long sum)
        {
            var startNode = FindRootNode() as Tree<int>;
            Stack<Tree<int>> stack = new Stack<Tree<int>>();
            Tree<int>[] longestPath = new Tree<int>[] { };
            Stack<Tree<int>[]> paths = new Stack<Tree<int>[]>();
            Stack<Tree<int>> tempPath = new Stack<Tree<int>>();
            stack.Push(startNode);
            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();
                if (currentNode.Children.Count == 0)
                {
                    var node = currentNode;
                    while (null != node)
                    {
                        tempPath.Push(node);
                        node = node.Parent;
                    }
                }

                if (tempPath.Sum(x => x.Value) == sum)
                {
                    paths.Push(tempPath.ToArray());
                }
                tempPath.Clear();

                foreach (var child in currentNode.Children)
                {
                    stack.Push(child);
                }
            }
            return paths.ToArray();
        }

        public static IEnumerable<Tree<int>> GetSubtreeNodesForNode(Tree<int> rootNode)
        {
            Stack<Tree<int>> stack = new Stack<Tree<int>>();
            Stack<Tree<int>> subtreeValues = new Stack<Tree<int>>();
            stack.Push(rootNode);
            while(stack.Count > 0)
            {
                var currentNode = stack.Pop();
                subtreeValues.Push(currentNode);
                foreach (var child in currentNode.Children)
                {
                    stack.Push(child);
                }
            }

            return subtreeValues;
        }

        public static void SubtreeSums(int sum)
        {
            foreach (var node in nodeByValue)
            {
                Tree<int> n = node.Value as Tree<int>;
                var nodes = GetSubtreeNodesForNode(n);
                int currentSum = 0;
                foreach (var item in nodes)
                {
                    currentSum += item.Value;
                }
                if(currentSum == sum)
                {
                    Console.WriteLine(string.Join(" + ", nodes));
                }
            }
        }


        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
