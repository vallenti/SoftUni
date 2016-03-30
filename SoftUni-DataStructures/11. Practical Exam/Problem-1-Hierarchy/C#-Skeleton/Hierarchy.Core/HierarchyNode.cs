using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy.Core
{
    internal class HierarchyNode<T>
    {
        public HierarchyNode(T value, HierarchyNode<T> parent = null)
        {
            this.Parent = parent;
            this.Value = value;
            this.Children = new List<HierarchyNode<T>>();
        }

        public T Value { get; set; }

        public HierarchyNode<T> Parent { get; set; }

        public List<HierarchyNode<T>> Children { get; set; }
    }
}
