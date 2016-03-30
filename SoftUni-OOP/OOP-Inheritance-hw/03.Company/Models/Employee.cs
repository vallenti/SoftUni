using _03.Company.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company
{
    public abstract class Employee : Person, IEmployee
    {
        private decimal salary;

        protected Employee(int id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get{ return this.salary; }
            protected set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("salary cannot be nagitve number");
                }
                this.salary = value;
            }
        }
        public Department Department { get; protected set; }

        public override string ToString()
        {
            return base.ToString()+" "+this.Salary+" "+this.Department;
        }
    }
}
