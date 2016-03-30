namespace AvlTreeLab
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class AvlTree<T> where T : IComparable<T>
    {
        private Node<T> root;

        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }

                var currentNode = this.root;
                while(true)
                {
                    var leftCount = currentNode.LeftChild == null ? 0 : currentNode.LeftChild.Count;
                    if(leftCount == index)
                    {
                        return currentNode.Value;
                    }
                    else if(leftCount > index)
                    {
                        currentNode = currentNode.LeftChild;
                    }
                    else
                    {
                        index -= leftCount + 1;
                        currentNode = currentNode.RightChild;
                    }
                }
            }
        }

        public void Add(T item)
        {
            if(this.Contains(item))
            {
                return;
            }

            bool inserted = true;
            if(this.root == null)
            {
                this.root = new Node<T>(item);
            }
            else
            {
                inserted = this.InsertInternal(this.root, item);
            }

            if(inserted)
            {
                this.Count++;
            }
        }

        private bool InsertInternal(Node<T> node, T item)
        {
            var currentNode = node;
            var newNode = new Node<T>(item);
            bool shouldRetrace = false;
            while(true)
            {
                if(currentNode.Value.CompareTo(item) < 0) //Node value is less than item => go right
                {
                    if(currentNode.RightChild == null)
                    {
                        currentNode.RightChild = newNode;
                        currentNode.BalanceFactor--;
                        shouldRetrace = currentNode.BalanceFactor != 0;
                        break;
                    }

                    currentNode = currentNode.RightChild;
                }
                else //Node value is more than item => go left
                {
                    if(currentNode.LeftChild == null)
                    {
                        currentNode.LeftChild = newNode;
                        currentNode.BalanceFactor++;
                        shouldRetrace = currentNode.BalanceFactor != 0;
                        break;
                    }

                    currentNode = currentNode.LeftChild;
                }
            }

            this.ModifyPredecessorsCounts(currentNode);

            if(shouldRetrace)
            {
                this.RetraceInsert(currentNode);
            }

            return true;
        }

        private void ModifyPredecessorsCounts(Node<T> startNode)
        {
            while(startNode != null)
            {
                startNode.Count++;

                startNode = startNode.Parent;
            }
        }

        private void RetraceInsert(Node<T> node)
        {
            var parent = node.Parent;
            while(parent != null)
            {
                if(node.IsLeftChild)
                {
                    //Node is left => parent's left subtree has grown
                    if(parent.BalanceFactor == 1)
                    {
                        parent.BalanceFactor++;
                        
                        if(node.BalanceFactor == -1)
                        {
                            this.RotateLeft(node);
                        }

                        this.RotateRight(parent);
                        break;
                    }
                    else if(parent.BalanceFactor == -1)
                    {
                        parent.BalanceFactor = 0;
                        break;
                    }
                    else
                    {
                        parent.BalanceFactor = 1;
                    }
                }
                else
                {
                    //Node is right => parent's right subtree has grown
                    if(parent.BalanceFactor == -1)
                    {
                        parent.BalanceFactor--;
                        if(node.BalanceFactor == 1)
                        {
                            this.RotateRight(node);
                        }

                        this.RotateLeft(parent);
                        break;
                    }
                    else if(parent.BalanceFactor == 1)
                    {
                        parent.BalanceFactor = 0;
                        break;
                    }
                    else
                    {
                        parent.BalanceFactor = -1;
                    }
                }
            }
        }

        private void RotateLeft(Node<T> node)
        {
            var parent = node.Parent;
            var child = node.RightChild;
            if(parent != null)
            {
                if(node.IsLeftChild)
                {
                    parent.LeftChild = child;
                }
                else
                {
                    parent.RightChild = child;
                }
            }
            else
            {
                this.root = child;
                this.root.Parent = null;
            }

            node.RightChild = child.LeftChild;
            child.LeftChild = node;

            node.UpdateCounts();
            child.UpdateCounts();

            node.BalanceFactor += 1 - Math.Min(child.BalanceFactor, 0);
            child.BalanceFactor += 1 + Math.Max(node.BalanceFactor, 0);

        }

        private void RotateRight(Node<T> node)
        {
            var parent = node.Parent;
            var child = node.LeftChild;

            if (parent != null)
            {
                if (node.IsRightChild)
                {
                    parent.RightChild = child;
                }
                else
                {
                    parent.LeftChild = child;
                }
            }
            else
            {
                this.root = child;
                this.root.Parent = null;
            }

            node.LeftChild = child.RightChild;
            child.RightChild = node;

            node.UpdateCounts();
            child.UpdateCounts();

            node.BalanceFactor -= 1 + Math.Max(child.BalanceFactor, 0);
            child.BalanceFactor -= 1 - Math.Min(node.BalanceFactor, 0);

        }

        public bool Contains(T item)
        {
            var node = this.root;
            while(node != null)
            {
                if(node.Value.Equals(item))
                {
                    return true;
                }

                if (node.Value.CompareTo(item) < 0) 
                {
                    node = node.RightChild;
                }
                else 
                {
                    node = node.LeftChild;
                }
            }

            return false;
        }

        public IEnumerable<T> Range(T from, T to)
        {
            var itemsInRange = new List<T>();
            RangeInOrderDfs(this.root, from, to, p => itemsInRange.Add(p));
            return itemsInRange;
        }

        private void RangeInOrderDfs(Node<T> node, T from, T to, Action<T> action)
        {
            if(node.LeftChild != null && node.Value.CompareTo(from) >= 0)
            {
                this.RangeInOrderDfs(node.LeftChild, from, to, action);
            }

            if(node.Value.CompareTo(from) >= 0 && node.Value.CompareTo(to) <= 0)
            {
              action(node.Value);
            } 

            if(node.RightChild != null && node.Value.CompareTo(to) <= 0)
            {
                this.RangeInOrderDfs(node.RightChild, from, to, action);
            }
        }

        public void ForEachDfs(Action<int, T> action)
        {
            if(this.Count == 0)
            {
                return;
            }

            this.InOrderDfs(this.root, 1, action);
        }

        private void InOrderDfs(Node<T> node, int depth, Action<int, T> action)
        {
            if(node.LeftChild != null)
            {
                this.InOrderDfs(node.LeftChild, depth + 1, action);
            }

            action(depth, node.Value);

            if(node.RightChild != null)
            {
                this.InOrderDfs(node.RightChild, depth + 1, action);
            }
        }
    }
}
