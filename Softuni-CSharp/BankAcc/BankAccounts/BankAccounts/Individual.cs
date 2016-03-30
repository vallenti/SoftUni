using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsNamespace
{
    [Serializable]
    class Individual : Client
    {
        public enum sexEnum
        {
            мъж,
            жена
        }
        private string firstName;
        private string lastName;
        private int age;
        private string egn;
        private sexEnum sex;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        public sexEnum Sex
        {
            get
            {
                return this.sex;
            }
            set
            {
                this.sex = value;
            }
        }
        public string Egn
        {
            get
            {
                return this.egn;
            }
            set
            {
                this.egn = value;
            }
        }

        public Individual(string firstName, string lastName,string egn, int age, sexEnum sex)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.egn = egn;
            this.age = age;
            this.sex = sex;
        }

    }
}
