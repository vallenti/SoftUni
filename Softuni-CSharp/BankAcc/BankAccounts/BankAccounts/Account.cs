using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsNamespace
{
    class Account
    {
        private double balance;
        private double interest;
        public string iban;
        private Individual someClient;
        private Company someCompany;
        private string clientID;
        private string clientType;
        private string clientName;
        private string accountType;
        private double interestSum;
        

        protected Account(Individual someClient, double balance, double interest)
        {
            this.iban = GenerateIban();
            this.someClient = someClient;
            this.balance = balance;
            this.interest = interest;
        }
        protected Account(Company someCompany, double balance, double interest)
        {
            this.iban = GenerateIban();
            this.someCompany = someCompany;
            this.balance = balance;
            this.interest = interest;
        }
        protected Account()
        {

        }

        public double InterestSum
        {
            get
            {
                return this.balance * this.interest;
            }
        }
        public double Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }
        public double Interest
        {
            get { return interest; }
            set { interest = value; }
        }
        
        public Individual SomeClient
        {
            get
            {
                return this.someClient;
            }
            set
            {
                this.someClient = value;
            }
        }
        public string Iban
        {
            get
            {
                return this.iban;
            }
            set
            {
                this.iban = value;
            }
        }
        public string SomeCliendID
        {
            get
            {
                if (someClient is Individual)
                {
                    return this.someClient.Egn;
                }
                else
                {
                    return this.someCompany.Eik;
                }
            }
        }
        public string ClientType
        {
            get
            {
                if (someClient is Individual)
                {
                    return "клиент";
                }
                else
                {
                    return "фирма";
                }
            }
        }
        public string ClientName
        {
            get
            {
                if (someClient is Individual)
                {
                    return this.someClient.FirstName + " " + this.someClient.LastName;
                }
                else
                {
                    return this.someCompany.Name;
                }
            }
        }
        public string AccountType
        {
            get
            {
                return this.accountType;
            }
            set
            {
                this.accountType = value;
            }
        }
        public string GenerateIban()
        {
            StringBuilder ibanSB = new StringBuilder();
            Random randGen = new Random();
            ibanSB.Append("BG12 BANK ");
            for (int i = 1; i < 15; i++)
            {
                ibanSB.Append(randGen.Next(0, 10).ToString());
            }
            return ibanSB.ToString();
        }

        public virtual void Deposit(double money)
        {
            this.balance += money;
        }
        public virtual void Drow(double money)
        {
            if (balance < money)
            {
                throw new Exception("Not enough money in account");
            }
            else
            {
                this.balance -= money;
            }
        }
    }
}
