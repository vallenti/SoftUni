using System;

namespace AvlTreeLab
{
    public class Node<T> where T : IComparable<T>
    {
        private Node<T> leftChild;
        private Node<T> rightChild;

        public Node(T value)
        {
            this.Value = value;
            this.Count = 1;
        }

        public T Value { get; set; }
        public Node<T> Parent { get; set; }
        public Node<T> LeftChild
        {
            get
            {
                return this.leftChild;
            }
            set
            {
                if(value != null)
                {
                    value.Parent = this;
                }

                this.leftChild = value;
            }
        }
        public Node<T> RightChild
        {
            get
            {
                return this.rightChild;
            }
            set
            {
                if(value != null)
                {
                    value.Parent = this;
                }

                this.rightChild = value;
            }
        }
        public int BalanceFactor { get; set; }

        public bool IsLeftChild
        {
            get
            {
                return this.Parent != null && this.Parent.LeftChild == this;
            }
        }

        public bool IsRightChild
        {
            get
            {
                return this.Parent != null && Parent.RightChild == this;
            }
        }

        public int ChildrenCount
        {
            get
            {
                if(this.LeftChild != null && this.RightChild != null)
                {
                    return 2;
                }
                else if(this.LeftChild != null || this.RightChild != null)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int Count { get; set; }

        public void UpdateCounts()
        {
            this.Count = 1;
            if(this.LeftChild != null)
            {
                this.Count += this.LeftChild.Count;
            }

            if(this.RightChild != null)
            {
                this.Count += this.RightChild.Count;
            }
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}

