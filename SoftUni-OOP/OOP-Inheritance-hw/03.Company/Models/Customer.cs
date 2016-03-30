using _03.Company.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company
{
    class Customer : Person, ICustomer
    {
        private decimal netPurchaseAmount;

        public Customer(int id, string firstName, string lastName)
            : base(id, firstName, lastName)
        {
            netPurchaseAmount = 0;
        }

        public decimal NetPurchaseAmount
        {
            get
            {
                return this.netPurchaseAmount;
            }
        }

        public void MakePurchase(Sale sale)
        {
            netPurchaseAmount += sale.Price;
        }
    }
}
