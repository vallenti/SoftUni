using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company.Interfaces
{
    interface IPerson
    {
        int Id { get; }
        string FirstName { get; }
        string LastName { get; }
    }
}
