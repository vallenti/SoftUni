﻿using System;

class ZeroSubset
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        bool hasSubset = false;
        if (a == 0)
        {
            Console.WriteLine("{0} = 0",a);
            hasSubset = true;
        }
        if (b == 0)
        {
            Console.WriteLine("{0} = 0", b);
            hasSubset = true;
        }
        if (c == 0)
        {
            Console.WriteLine("{0} = 0", c);
            hasSubset = true;
        }
        if (d == 0)
        {
            Console.WriteLine("{0} = 0", d);
            hasSubset = true;
        }
        if (e == 0)
        {
            Console.WriteLine("{0} = 0", e);
            hasSubset = true;
        }
        if (a + b == 0)
        {
            Console.WriteLine("{0}+{1} = 0",a,b);
            hasSubset = true;
        }
        if (a + c == 0)
        {
            Console.WriteLine("{0}+{1} = 0", a, c);
            hasSubset = true;
        }
        if (a + d == 0)
        {
            Console.WriteLine("{0}+{1} = 0", a, d);
            hasSubset = true;
        }
        if (a + e == 0)
        {
            Console.WriteLine("{0}+{1} = 0", a, e);
            hasSubset = true;
        }
        if (b + c == 0)
        {
            Console.WriteLine("{0}+{1} = 0", b, c);
            hasSubset = true;
        }
        if (b + d == 0)
        {
            Console.WriteLine("{0}+{1} = 0", b, d);
            hasSubset = true;
        }
        if (b + e == 0)
        {
            Console.WriteLine("{0}+{1} = 0", b, e);
            hasSubset = true;
        }
        if (c + d == 0)
        {
            Console.WriteLine("{0}+{1} = 0", c, d);
            hasSubset = true;
        }
        if (c + e == 0)
        {
            Console.WriteLine("{0}+{1} = 0", c, e);
            hasSubset = true;
        }
        if (d + e == 0)
        {
            Console.WriteLine("{0}+{1} = 0", d, e);
            hasSubset = true;
        }
        if (a + b + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
            hasSubset = true;
        }
        if (a + b + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
            hasSubset = true;
        }
        if (a + b + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
            hasSubset = true;
        }
        if (a + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
            hasSubset = true;
        }
        if (a + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
            hasSubset = true;
        }
        if (a + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
            hasSubset = true;
        }
        if (b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
            hasSubset = true;
        }
        if (b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
            hasSubset = true;
        }
        if (b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
            hasSubset = true;
        }
        if (c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
            hasSubset = true;
        }
        if (a + b + c + d == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3} = 0", a, b, c, d);
            hasSubset = true;
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3} = 0", a, b, c, e);
            hasSubset = true;
        }
        if (a + b + d + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3} = 0", a, b, d, e);
            hasSubset = true;
        }
        if (a + c + d + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3} = 0", a, c, d, e);
            hasSubset = true;
        }
        if (b + c + d + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3} = 0", b, c, d, e);
            hasSubset = true;
        }
        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3}+{4} = 0", a, b, c, d, e);
            hasSubset = true;
        }
        if (!hasSubset)
        {
            Console.WriteLine("no zero subset");
        }
    }
}
