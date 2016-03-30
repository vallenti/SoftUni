using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsNamespace
{
    [Serializable]
    class Company : Client
    {
        private string name;
        private string eik;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Eik
        {
            get
            {
                return this.eik;
            }
            set
            {
                this.eik = value;
            }
        }

        public Company(string name, string eik)
        {
            this.name = name;
            this.eik = eik;
        }
    }
}
