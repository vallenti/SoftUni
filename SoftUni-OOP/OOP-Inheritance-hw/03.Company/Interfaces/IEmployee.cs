using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company.Interfaces
{
    interface IEmployee
    {
        decimal Salary { get; }
        Department Department { get; }
    }
}
