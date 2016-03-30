using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CustomLINQ
{
    static class ExtentionMethods
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var result = new List<T>();
            foreach (var element in collection)
            {
                if(!predicate(element))
                {
                    result.Add(element);
                }
            }
            return result;
        }
        public static TSelector Max<TSource, TSelector>(
            this IEnumerable<TSource> collection, 
            Func<TSource, TSelector> predicate)
            where TSelector : IComparable
        {
            TSelector max = predicate(collection.First());
            foreach (var element in collection)
            {
                var current = predicate(element);
                if (max.CompareTo(current) < 0)
                {
                    max = current;
                }
            }
            return max;
        }
    }
}
