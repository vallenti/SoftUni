using System;


class CheckSubset
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        bool flag = true;

        
        //check for subsets with 4 numbers
        if (a + b + c + d == 0)
        {
            Console.WriteLine("{0} {1} {2} {3}", a, b, c, d);
            flag = false;
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine("{0} {1} {2} {3}", a, b, c, e);
            flag = false;
        }
        if (a + b + d + e == 0)
        {
            Console.WriteLine("{0} {1} {2} {3}", a, b, d, e);
            flag = false;
        }
        if (a + c + d + e == 0)
        {
            Console.WriteLine("{0} {1} {2} {3}", a, c, d, e);
            flag = false;
        }
        if (b + c + d + e == 0)
        {
            Console.WriteLine("{0} {1} {2} {3}", b, c, d, e);
            flag = false;
        }

        //check for subsets with 3 numbers
        if (a + b + c == 0)
        {
            Console.WriteLine("{0} {1} {2}",a, b, c);
            flag = false;
        }
        if (a + b + d == 0)
        {
            Console.WriteLine("{0} {1} {2}", a, b, d);
            flag = false;
        }
        if (a + b + e == 0)
        {
            Console.WriteLine("{0} {1} {2}", a, b, e);
            flag = false;
        }
        if (a + c + d == 0)
        {
            Console.WriteLine("{0} {1} {2}", a, c, d);
            flag = false;
        }
        if (a + c + e == 0)
        {
            Console.WriteLine("{0} {1} {2}", a, c, e);
            flag = false;
        }
        if(a+d+e==0)
        {
            Console.WriteLine("{0} {1} {2}", a, d, e);
            flag = false;
        }
        if (b + c + d == 0)
        {
            Console.WriteLine("{0} {1} {2}", b, c, d);
            flag = false;
        }
        if (b + c + e == 0)
        {
            Console.WriteLine("{0} {1} {2}", b, c, e);
            flag = false;
        }
        if(b+d+e==0)
        {
            Console.WriteLine("{0} {1} {2}", b, d, e);
            flag = false;
        }
        if (c + d + e == 0)
        {
            Console.WriteLine("{0} {1} {2}", c, d, e);
            flag = false;
        }

        //check for subsets with 2 numbers
        if (a + b == 0)
        {
            Console.WriteLine("{0} {1}", a, b);
            flag = false;
        }
        if (a + c == 0)
        {
            Console.WriteLine("{0} {1}", a, c);
            flag = false;
        }
        if (a + d == 0)
        {
            Console.WriteLine("{0} {1}", a, d);
            flag = false;
        }
        if (a + e == 0)
        {
            Console.WriteLine("{0} {1}", a, e);
            flag = false;
        }
        if (b + c == 0)
        {
            Console.WriteLine("{0} {1}", b, c);
            flag = false;
        }
        if (b + d == 0)
        {
            Console.WriteLine("{0} {1}", b, d);
            flag = false;
        }
        if (b + e == 0)
        {
            Console.WriteLine("{0} {1}", b, e);
            flag = false;
        }
        if (c + d == 0)
        {
            Console.WriteLine("{0} {1}", c, d);
            flag = false;
        }
        if (c + e == 0)
        {
            Console.WriteLine("{0} {1}", c, e);
            flag = false;
        }
        if (d + e == 0)
        {
            Console.WriteLine("{0} {1}", d, e);
            flag = false;
        }
        if(flag)
        {
            Console.WriteLine("There is no subset with sum equals to 0");
        }
    }
}