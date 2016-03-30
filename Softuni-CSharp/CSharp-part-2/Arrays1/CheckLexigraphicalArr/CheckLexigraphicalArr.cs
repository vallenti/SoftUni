using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLexigraphicalArr
{
    class CheckLexigraphicalArr
    {
        static public bool isEqual = true;
        static public char[] Array1 = { 'a', 'b', 'c', 'd', 'e' };
        static public char[] Array2 = { 'a', 'b', 'c', 'd', 'e', 'j' };
        static public void CompareElements(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (Array1[i] != Array2[i]) 
                    isEqual = false;
                if (!isEqual)
                {
                    if (Array1[i] > Array2[i])
                    {
                        Console.WriteLine("Array2 is before Array1."); break;
                    }
                    else
                    {
                        Console.WriteLine("Array1 is before Array2."); break;
                    }
                }

            }
        }
        static void Main()
        {
            if (Array1.Length == Array2.Length)
            {
                CompareElements(Array1.Length);
                if (isEqual) Console.WriteLine("Arrays are equal.");
            }
            else
            {
                if (Array1.Length > Array2.Length)
                {
                    CompareElements(Array2.Length);
                    if (isEqual) Console.WriteLine("Array2 is before Array1.");
                }
                else
                {
                    CompareElements(Array1.Length);
                    if (isEqual) Console.WriteLine("Array1 is before Array2.");
                }
            }
        }
    }
}
