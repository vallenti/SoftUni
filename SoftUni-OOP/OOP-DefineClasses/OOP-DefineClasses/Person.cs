using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DefineClasses
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public string Name {
            get
            {
                return this.name;
            }
            set
            {
                if(String.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("Name cannot be empty or null.");
                }
                this.name = value;
            }
        }
        public int Age {
            get
            {
                return this.age;
            }
            set
            {
                if(value < 1 || value > 100)
                {
                    throw new ArgumentException("Invalid Age. Must be in range [1-100]");
                }
                this.age = value;
            }
        }
        public string Email {
            get
            {
                return this.email;
            }
            set
            {
                if(value == null || ValidateEmail(value))
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentException("Email can be only null and in correct format.");
                }
            }
        }

        public Person(string name, int age)
            : this(name, age, null)
        {
        }

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        private bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        public override string ToString()
        {
            return String.Format("Name: {0} | Age: {1} | Email: {2}",
                                    this.Name, this.Age, this.Email ?? "[unknown email]");
        }
    }
}
