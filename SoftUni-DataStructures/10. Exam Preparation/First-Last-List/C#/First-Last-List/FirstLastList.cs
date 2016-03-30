using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

public class FirstLastList<T> : IFirstLastList<T>
    where T : IComparable<T>
{
    private LinkedList<T> elements = new LinkedList<T>();
    private OrderedBag<T> elemntsByValue = new OrderedBag<T>();
    private OrderedDictionary<T, List<LinkedListNode<T>>> orderedElements = new OrderedDictionary<T, List<LinkedListNode<T>>>();

    public void Add(T newElement)
    {
        var newNode = new LinkedListNode<T>(newElement);
        elements.AddLast(newNode);
        elemntsByValue.Add(newElement);
        if(!orderedElements.ContainsKey(newElement))
        {
            orderedElements.Add(newElement, new List<LinkedListNode<T>>());
        }

        orderedElements[newElement].Add(newNode);
    }

    public int Count
    {
        get
        {
            return this.elements.Count;
        }
    }

    public IEnumerable<T> First(int count)
    {
        this.ValidateCount(count);

        return elements.Take(count);
    }

    public IEnumerable<T> Last(int count)
    {
        this.ValidateCount(count);

        return elements.Reverse().Take(count);
    }

    public IEnumerable<T> Min(int count)
    {
        this.ValidateCount(count);

        return orderedElements
            .SelectMany(e => e.Value)
            .Select(e => e.Value)
            .Take(count);
    }

    public IEnumerable<T> Max(int count)
    {
        this.ValidateCount(count);

        return orderedElements
            .Reversed()
            .SelectMany(e => e.Value)
            .Select(e => e.Value)
            .Take(count);
    }

    public int RemoveAll(T element)
    {
        if(!orderedElements.ContainsKey(element))
        {
            return 0;
        }

        foreach (var item in orderedElements[element])
        {
            elements.Remove(item);
        }

        var removedElements = orderedElements[element].Count;
        orderedElements.Remove(element);
        return removedElements;
    }

    public void Clear()
    {
        elements.Clear();
        elemntsByValue.Clear();
        orderedElements.Clear();
    }

    private void ValidateCount(int count)
    {
        if (this.Count < count)
        {
            throw new ArgumentOutOfRangeException("count parameter cannot be less than the count of elements in collection");
        }
    }
}
