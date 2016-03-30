namespace _01.ReverseNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseNumbers
    {
        public static void Main()
        {
            Stack<int> numbers = 
                new Stack<int>(
                    Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray());

            while(numbers.Count > 0)
            {
                Console.Write(numbers.Pop()+" ");
            }
        }
    }
}
