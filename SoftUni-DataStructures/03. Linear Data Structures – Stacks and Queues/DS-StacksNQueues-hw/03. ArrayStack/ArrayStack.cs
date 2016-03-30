using System;

namespace _03.ArrayStackGeneric
{
    public class ArrayStack<T>
    {
        private const int InitialCapacity = 16;
        private T[] elements;

        public ArrayStack(int capacity = InitialCapacity)
        {
            this.elements = new T[capacity];
        }

        public int Count { get; private set; }
        public int Capacity
        {
            get
            {
                return this.elements.Length;
            }
        }

        public void Push(T element)
        {
            if(this.Count == this.elements.Length)
            {
                this.Grow();
            }

            this.elements[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("Cannot pop from empty stack.");
            }

            this.Count--;
            T resutlElement = this.elements[this.Count];
            return resutlElement;
        }

        public T[] ToArray()
        {
            var resultArray = new T[this.Count];
            var elementsIndex = this.Count-1;
            for (int i = 0; i < this.Count; i++)
            {
                resultArray[i] = this.elements[elementsIndex];
                elementsIndex--;
            }
            return resultArray;
        }

        private void Grow()
        {
            var newElements = new T[2 * this.elements.Length];
            Array.Copy(this.elements, newElements, this.Count);
            this.elements = newElements;
        }
    }
}
