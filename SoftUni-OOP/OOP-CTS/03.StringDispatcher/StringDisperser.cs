using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StringDispatcher
{
    class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable<char>
    {

        public StringDisperser(params string[] strings)
        {
            this.ConcatenatedString = ConcatenateStrings(strings);
        }

        

        public string ConcatenatedString { get; private set; }

        private string ConcatenateStrings(string[] strings)
        {
            StringBuilder result = new StringBuilder();
            foreach (string s in strings)
            {
                result.Append(s);
            }
            return result.ToString();
        }
        public override bool Equals(object obj)
        {
            var other = obj as StringDisperser;
            return object.Equals(this.ConcatenatedString, other.ConcatenatedString);
        }
        public static bool operator ==(StringDisperser a, StringDisperser b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(StringDisperser a, StringDisperser b)
        {
            return !(a == b);
        }
        public override int GetHashCode()
        {
            return this.ConcatenatedString.GetHashCode();
        }
        public override string ToString()
        {
            return this.ConcatenatedString;
        }

        public object Clone()
        {
            return new StringDisperser(ConcatenatedString);
        }

        public int CompareTo(StringDisperser other)
        {
            return string.Compare(this.ConcatenatedString, other.ConcatenatedString, true);
        }

        public IEnumerator<char> GetEnumerator()
        {
            for (int i = 0; i < this.ConcatenatedString.Length; i++)
            {
                yield return ConcatenatedString[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
