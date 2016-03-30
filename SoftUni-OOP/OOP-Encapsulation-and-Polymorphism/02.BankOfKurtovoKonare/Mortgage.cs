using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankOfKurtovoKonare
{
    public class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override decimal CalculateInterest(int months)
        {
            if(this.Customer is IndividualCustumer)
            {
                months -= 6;
            }
            if(this.Customer is Company)
            {
                months -= 3;
            }
            return base.CalculateInterest(months);
        }
    }
}
