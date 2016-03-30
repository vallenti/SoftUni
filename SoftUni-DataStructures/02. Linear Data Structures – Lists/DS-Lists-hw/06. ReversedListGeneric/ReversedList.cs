namespace _06.ReversedListGeneric
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class ReversedList<T> : IEnumerable<T>
    {
        private const int DefaultCapacity = 16;
        private T[] array;

        public ReversedList(int capacity = DefaultCapacity)
        {
            array = new T[capacity];
            this.Count = 0;
        }

        public int Count { get; private set; }

        public int Capacity
        {
            get
            {
                return this.array.Length;
            }
        }

        public void Add(T element)
        {
            if(this.Count >= this.array.Length)
            {
                this.Resize(this.Capacity * 2);
            }

            this.array[this.Count] = element;
            this.Count++;
        }

        public T Remove(int index)
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("Cannot remove element from empty list.");
            }

            T[] newArray = new T[this.array.Length];
            T element = this.array[this.Count - index - 1];

            for (int i = 0; i < this.Count; i++)
            {
                if(i < index)
                {
                    newArray[this.Count - i - 1] = this.array[this.Count - i - 1];
                }
                else if(i > index)
                {
                    newArray[this.Count - i - 1] = this.array[this.Count - i - 1];
                }
            }

            this.array = newArray;
            this.Count--;

            return element;
        }

        public T this[int index]
        {
            get
            {
                return array[this.Count - index - 1];
            }

            set
            {
                array[this.Count - index - 1] = value;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.array[this.Count - i - 1];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void Resize(int capacity)
        {
            Array.Resize(ref this.array, capacity);
        }
    }
}
