using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OrderedSet
{
    public class OrderedSet<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        private Node<T> root;

        public OrderedSet()
        {
            this.root = null;
        }

        public int Count { get; private set; }

        public void Add(T element)
        {
            if(this.root == null)
            {
                this.root = new Node<T>(element);
                this.Count++;
            }
            else
            {
                var currentNode = this.root;
                while(true)
                {
                    int compareResult = currentNode.Value.CompareTo(element);
                    if(compareResult == 0)
                    {
                        return;
                    }
                    else if(compareResult < 0)
                    {
                        if(currentNode.RightChild == null)
                        {
                            currentNode.RightChild = new Node<T>(element, currentNode);
                            this.Count++;
                            return;
                        }

                        currentNode = currentNode.RightChild;
                    }
                    else if(compareResult > 0)
                    {
                        if(currentNode.LeftChild == null)
                        {
                            currentNode.LeftChild = new Node<T>(element, currentNode);
                            this.Count++;
                            return;
                        }

                        currentNode = currentNode.LeftChild;
                    }
                }
            }
        }

        public bool Contains(T element)
        {
            var currentNode = this.root;
            while(currentNode != null)
            {
                var compareResult = currentNode.Value.CompareTo(element);
                if(compareResult == 0)
                {
                    return true;
                }
                else if(compareResult < 0)
                {
                    currentNode = currentNode.RightChild;
                }
                else if(compareResult > 0)
                {
                    currentNode = currentNode.LeftChild;
                }
            }

            return false;
        }

        public void Remove(T element)
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("Cannot remove from empty set");
            }
            

        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.root.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
