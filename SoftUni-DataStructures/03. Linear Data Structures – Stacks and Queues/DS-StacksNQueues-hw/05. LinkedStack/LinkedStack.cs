using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LinkedStackGeneric
{
    public class LinkedStack<T>
    {
        private Node<T> firstNode;
        public int Count { get; private set; }

        public void Push(T element)
        {
            this.firstNode = new Node<T>(element, this.firstNode);
            this.Count++;
        }

        public T Pop()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("Cannot pop from empty stack.");
            }

            T resultValue = this.firstNode.Value;
            this.firstNode = this.firstNode.NextNode;
            this.Count--;
            return resultValue;
        }

        public T[] ToArray()
        {
            T[] resultArray = new T[this.Count];
            int index = 0;
            var currentNode = this.firstNode;
            while (currentNode != null)
            {
                resultArray[index++] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }

            return resultArray;
        }

        private class Node<T>
        {
            public Node(T value, Node<T> nextNode = null)
            {
                this.Value = value;
                this.NextNode = nextNode;
            }

            public T Value { get; private set; }
            public Node<T> NextNode { get; set; }
        }
    }
}
