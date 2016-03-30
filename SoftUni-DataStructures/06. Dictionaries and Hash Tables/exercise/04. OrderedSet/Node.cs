
namespace _04.OrderedSet
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Node<T> : IEnumerable<T>
    {
        public Node(T value, Node<T> parent = null)
        {
            this.Value = value;
            this.Parent = parent;
        }

        public T Value { get; set; }
        public Node<T> Parent { get; set; }
        public Node<T> LeftChild { get; set; }
        public Node<T> RightChild { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            if(this.LeftChild != null)
            {
                foreach (var child in this.LeftChild)
                {
                    yield return child;
                }
            }

            yield return this.Value;

            if (this.RightChild != null)
            {
                foreach (var child in this.RightChild)
                {
                    yield return child;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

}
