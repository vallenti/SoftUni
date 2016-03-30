using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SequenceNtoM
{
    class SequenceItem<T>
    {
        public SequenceItem(T value, SequenceItem<T> previousItem = null)
        {
            this.Value = value;
            this.PreviousItem = previousItem;
        }

        public T Value { get; set; }
        public SequenceItem<T> PreviousItem { get; set; }
    }
}
