using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsNamespace
{
    [Serializable]
    class LoanAccount : Account
    {
        private int loanPeriod;
        public LoanAccount(Individual someClient, double balance, double interest, int loanPeriod)
            : base(someClient, balance, interest)
        {
            this.loanPeriod = loanPeriod;
            this.AccountType = "заем";
        }
        public LoanAccount(Company someCompany, double balance, double interest, int loanPeriod)
            : base(someCompany, balance, interest)
        {
            this.loanPeriod = loanPeriod;
            this.AccountType = "заем";
        }
        public override void Deposit(double money)
        {
            this.Balance += money;
        }
    }
}
