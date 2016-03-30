using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsNamespace
{
    [Serializable]
    class MortgageAccount : Account
    {
        private int mortgagePeriod;
        private Company newCompany;
        private int period;

        public int MortgagePeriod
        {
            get
            {
                return this.mortgagePeriod;
            }
            set
            {
                this.mortgagePeriod = value;
            }
        }

        public MortgageAccount(Individual someClient, double balance, double interest, int mortgagePeriod)
            : base(someClient, balance, interest)
        {
            this.mortgagePeriod = mortgagePeriod;
            this.AccountType = "ипотека";
        }
        public MortgageAccount(Company someCompany, double balance, double interest, int mortgagePeriod)
            : base(someCompany, balance, interest)
        {
            this.mortgagePeriod = mortgagePeriod;
            this.AccountType = "ипотека";
        }

        public MortgageAccount()
        {
            // TODO: Complete member initialization
        }


        public override void Deposit(double money)
        {
            this.Balance += money;
        }
    }
}
