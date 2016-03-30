namespace Hierarchy.Core
{
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using System.Linq;

    public class Hierarchy<T> : IHierarchy<T>
    {
        private HierarchyNode<T> root;
        private Dictionary<T, HierarchyNode<T>> nodes;

        public Hierarchy(T root)
        {
            this.root = new HierarchyNode<T>(root);
            this.nodes = new Dictionary<T, HierarchyNode<T>>();
            this.nodes.Add(root, this.root);
        }

        public int Count
        {
            get
            {
                return this.nodes.Count;
            }
        }

        public void Add(T element, T child)
        {
            HierarchyNode<T> parentNode;
            ValidateIfNodeAlreadyExists(element, out parentNode);

            if (this.nodes.ContainsKey(child))
            {
                throw new ArgumentException("Child cannot have 2 parents");
            }

            var childNode = new HierarchyNode<T>(child, parentNode);
            this.nodes[child] = childNode;
            parentNode.Children.Add(childNode);
        }

        public void Remove(T element)
        {
            HierarchyNode<T> node;
            ValidateIfNodeAlreadyExists(element, out node);

            if (node.Parent == null)
            {
                throw new InvalidOperationException("Cannot delete root element");
            }

            node.Parent.Children.AddRange(node.Children);
            foreach (var child in node.Children)
            {
                child.Parent = node.Parent;
            }

            this.nodes.Remove(element);
            node.Parent.Children.Remove(node);
        }

        public IEnumerable<T> GetChildren(T item)
        {
            HierarchyNode<T> node;
            ValidateIfNodeAlreadyExists(item, out node);

            return node.Children.Select(n => n.Value);
        }

        public T GetParent(T item)
        {
            HierarchyNode<T> node;
            ValidateIfNodeAlreadyExists(item, out node);

            if(node.Parent != null)
            {
                return node.Parent.Value;
            }
            else
            {
                return default(T);
            }
        }

        public bool Contains(T value)
        {
            return this.nodes.ContainsKey(value);
        }

        public IEnumerable<T> GetCommonElements(IHierarchy<T> other)
        {
            foreach (var key in this.nodes.Keys)
            {
                if (other.Contains(key))
                {
                    yield return key;
                }
            }
        } 

        public IEnumerator<T> GetEnumerator()
        {
            if (this.Count == 0)
            {
                yield break;
            }

            //BFS traversal of hierarchy
            var queue = new Queue<HierarchyNode<T>>();
            queue.Enqueue(this.root);
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                yield return current.Value;

                foreach (var subordinate in current.Children)
                {
                    queue.Enqueue(subordinate);
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void ValidateIfNodeAlreadyExists(T element, out HierarchyNode<T> node)
        {
            if (!this.nodes.TryGetValue(element, out node))
            {
                throw new ArgumentException("Element does not exist in hierarchy");
            }
        }
    }
}