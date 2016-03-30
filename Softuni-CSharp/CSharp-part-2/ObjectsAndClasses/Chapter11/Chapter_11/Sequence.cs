using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter11.Chapter_11
{
    class Sequence
    {
        static public string NextValue(int i)
        {
            string catname = "Cat" + i;
            return catname;
        }
    }
}
