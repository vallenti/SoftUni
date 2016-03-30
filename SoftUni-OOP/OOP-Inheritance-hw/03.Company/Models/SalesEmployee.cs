using _03.Company.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company
{
    class SalesEmployee : RegularEmployee, ISalesEmployee
    {

        public SalesEmployee(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary, Department.Sales)
        {
            this.Sales = new HashSet<Sale>();
        }

        public ISet<Sale> Sales { get; private set; }

        public void AddSale(Sale sale)
        {
            if(sale == null)
            {
                throw new ArgumentNullException("cannot add null sale");
            }
            Sales.Add(sale);
        }

        public override string ToString()
        {
            StringBuilder salesList = new StringBuilder();
            salesList.AppendLine();
            foreach (Sale sale in this.Sales)
            {
                salesList.AppendLine(sale.ToString());
            }
            return base.ToString()+salesList.ToString();
        }
    }
}
