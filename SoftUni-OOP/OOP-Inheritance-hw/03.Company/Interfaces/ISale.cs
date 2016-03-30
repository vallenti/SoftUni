using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company.Interfaces
{
    interface ISale
    {
        string Name { get; set; }
        DateTime Date { get; set; }
        decimal Price { get; set; }
    }
}
