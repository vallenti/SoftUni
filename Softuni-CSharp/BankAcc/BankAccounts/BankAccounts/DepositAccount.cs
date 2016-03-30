using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsNamespace
{
    [Serializable]
    class DepositAccount : Account
    {
        private int depositPeriod;
        public DepositAccount(Individual someClient, double balance, double interest, int depositPeriod)
            : base(someClient, balance, interest)
        {
            this.depositPeriod = depositPeriod;
            this.AccountType = "депозит";
        }
        public DepositAccount(Company someCompany, double balance, double interest, int depositPeriod)
            : base(someCompany, balance, interest)
        {
            this.depositPeriod = depositPeriod;
            this.AccountType = "депозит";
        }

        public override void Deposit(double money)
        {
            this.Balance += money;
        }
        public override void Drow(double money)
        {
            if (this.Balance >= money)
            {
                this.Balance -= money;
            }
            else
            {
                throw new Exception("Not enough money in account");
            }
        }
    }
}
