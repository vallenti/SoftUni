using _03.Company.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company
{
    public abstract class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        protected Person(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("ID cannot be negaitve number");
                }
                this.id = value;
            }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if(value == null)
                {
                    throw new ArgumentException("First name cannot be null");
                }
                if(value.Trim().Length < 3)
                {
                    throw new ArgumentException("First name cannot be less than 3 symbols long");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Last name cannot be null");
                }
                if (value.Trim().Length < 3)
                {
                    throw new ArgumentException("Last name cannot be less than 3 symbols long");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return this.Id + " " + this.FirstName + " " + this.LastName;
        }
    }
}
