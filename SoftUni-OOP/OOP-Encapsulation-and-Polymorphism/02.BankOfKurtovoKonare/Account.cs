using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankOfKurtovoKonare
{
    public abstract class Account : IDepositable
    {
        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }

        public virtual decimal CalculateInterest(int months)
        {
            return this.Balance * (1 + this.InterestRate * months);
        }

        public virtual void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

    }
}
