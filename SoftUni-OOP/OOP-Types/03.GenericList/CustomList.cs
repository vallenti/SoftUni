using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericList
{
    [Version(1,0)]
    class CustomList<T> 
        where T : IComparable<T>
    {
        private T[] array;
        private const int DefaultCapacity = 16;
        private int Capacity;
        private int count;

        public CustomList(int capacity = DefaultCapacity)
        {
            array = new T[capacity];
            count = 0;
            Capacity = capacity;
        }
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Add(T item)
        {
            Insert(count, item);
        }

        public int Remove(T item)
        {
            int index = IndexOf(item);
            if (index == -1)
            {
                return index;
            }

            Array.Copy(array, index + 1, array, index, count - index + 1);
            count--;

            return index;
        }
        public T Remove(int index)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException(
                      "Invalid index: " + index);
            }

            T item = array[index];
            Array.Copy(array, index + 1, array, index, count - index + 1);
            array[count - 1] = default(T);
            count--;

            return item;
        }

        public bool Contains(T item)
        {
            return array.Contains(item);
        }
        public void Clear()
        {
            array = new T[DefaultCapacity];
            count = 0;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if ((object)array[i] == (object)item)
                {
                    return i;
                }
            }
            return -1;
        }

        private void Resize(int capacity)
        {
            T[] newArray = new T[capacity];
            for (int i = 0; i < Capacity; i++)
            {
                newArray[i] = this.array[i];
            }
            this.array = newArray;
            this.Capacity = capacity;
        }

        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                          "Invalid index: " + index);
                }
                return array[index];
            }
            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                          "Invalid index: " + index);
                }
                array[index] = value;
            }
        }

        public T Min()
        {
            return array.Min();
        }

        public T Max()
        {
            return array.Max();
        }

        public void Insert(int index, T item)
        {
            if (index > count || index < 0)
            {
                throw new IndexOutOfRangeException(
                      "Invalid index: " + index);
            }
            T[] extendedArr = array;
            if (count + 1 == array.Length)
            {
                extendedArr = new T[array.Length * 2];
            }
            Array.Copy(array, extendedArr, index);
            count++;
            Array.Copy(array, index, extendedArr, index + 1, count - index - 1);
            extendedArr[index] = item;
            array = extendedArr;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append("[");
            foreach (T item in array)
            {
                if(item != null) {
                    output.Append(item + ", ");
                }
            }
            output.Replace(", ", "]", output.ToString().LastIndexOf(", "), 2);
            return output.ToString();
        }
    }
}
