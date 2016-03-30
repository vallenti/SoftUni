using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BiDictionary
{
    public class BiDictionary<K1, K2, T>
    {
        private Dictionary<K1, List<T>> valuesByFirstKey;
        private Dictionary<K2, List<T>> valuesBySecondKey;
        private Dictionary<Tuple<K1, K2>, List<T>> valuesByBothKeys;


        public BiDictionary()
        {
            this.valuesByFirstKey = new Dictionary<K1, List<T>>();
            this.valuesBySecondKey = new Dictionary<K2, List<T>>();
            this.valuesByBothKeys = new Dictionary<Tuple<K1, K2>, List<T>>();
        }

        public void Add(K1 key1, K2 key2, T value)
        {
            var keyCombination = CreateKeyCombination(key1, key2);
            if (!valuesByBothKeys.ContainsKey(keyCombination))
            {
                valuesByBothKeys.Add(keyCombination, new List<T>());
            }

            if(!valuesByFirstKey.ContainsKey(key1))
            {
                valuesByFirstKey.Add(key1, new List<T>());
            }

            if(!valuesBySecondKey.ContainsKey(key2))
            {
                valuesBySecondKey.Add(key2, new List<T>());
            }

            valuesByBothKeys[keyCombination].Add(value);
            valuesByFirstKey[key1].Add(value);
            valuesBySecondKey[key2].Add(value);
        }

        public IEnumerable<T> Find(K1 key1, K2 key2)
        {
            var keyCombination = CreateKeyCombination(key1, key2);
            if (valuesByBothKeys.ContainsKey(keyCombination))
            {
                return valuesByBothKeys[keyCombination];
            }
            else
            {
                return new T[0];
            }
        }

        public IEnumerable<T> FindByKey1(K1 key1)
        {
            if(valuesByFirstKey.ContainsKey(key1))
            {
                return valuesByFirstKey[key1];
            }
            else
            {
                return new T[0];
            }
        }

        public IEnumerable<T> FindByKey2(K2 key2)
        {
            if (valuesBySecondKey.ContainsKey(key2))
            {
                return valuesBySecondKey[key2];
            }
            else
            {
                return new T[0];
            }
        }


        public bool Remove(K1 key1, K2 key2)
        {
            var keyCombination = CreateKeyCombination(key1, key2);

            if(!valuesByBothKeys.ContainsKey(keyCombination))
            {
                return false;
            }

            valuesByBothKeys.Remove(keyCombination);
            valuesByFirstKey.Remove(key1);
            valuesBySecondKey.Remove(key2);

            return true;
        }

        private Tuple<K1, K2> CreateKeyCombination(K1 key1, K2 key2)
        {
            return new Tuple<K1, K2>(key1, key2);
        }
    }
}
