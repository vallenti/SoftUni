using _03.Company.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company
{
    class Manager : Employee, IManager
    {

        public Manager(int id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {
            this.Employees = new HashSet<Employee>();
        }

        public ISet<Employee> Employees { get; private set; }

        public void AddEmployee(Employee emp)
        {
            if(emp == null)
            {
                throw new ArgumentNullException("Cannot add null employee");
            }
            this.Employees.Add(emp);
        }

        public override string ToString()
        {
            StringBuilder employeesList = new StringBuilder();
            employeesList.AppendLine();
            foreach (Employee emp in this.Employees)
            {
                employeesList.AppendLine("-"+emp.ToString());
            }

            return base.ToString()+employeesList.ToString();
        }
    }
}
