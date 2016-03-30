using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankOfKurtovoKonare
{
    public class Loan : Account
    {
        public Loan(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer is IndividualCustumer)
            {
                months -= 3;
            }
            if (this.Customer is Company)
            {
                months -= 2;
            }
            return base.CalculateInterest(months);
        }

    }
}
