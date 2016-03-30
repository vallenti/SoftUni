using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Customer
{
    class Customer : ICloneable, IComparable<Customer>
    {
        public Customer(
            string firstName,
            string middleName,
            string lastName,
            string id,
            string address,
            string mobilePhone,
            string email,
            CustomerType type)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Id = id;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Type = type;
            this.Payments = new List<Payment>();
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public IList<Payment> Payments { get; private set; }
        public CustomerType Type { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + MiddleName + " " + LastName;
            }
        }

        public void AddPayment(Payment payment)
        {
            this.Payments.Add(payment);
        }

        public override bool Equals(object obj)
        {
            var other = obj as Customer;
            if(object.Equals(other, null))
            {
                return false;
            }
            return this.Id == other.Id;
        }
        public static bool operator ==(Customer a, Customer b)
        {
            if(object.Equals(a, null))
            {
                return false;
            }
            return a.Equals(b);
        }
        public static bool operator !=(Customer a, Customer b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode() ^ this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("{0}, ID: {1}\n", FullName, Id);
            output.AppendFormat("Address: {0}\n", Address);
            output.AppendFormat("Phone: {0}\n", MobilePhone);
            output.AppendFormat("Email: {0}\n", Email);
            output.AppendFormat("Customer type: {0}\n", Type);
            output.AppendLine("Payments:");
            if (Payments.Count > 0)
            {
                foreach (var payment in Payments)
                {
                    output.AppendLine("-" + payment);
                }
            }
            else
            {
                output.AppendLine("[no payments]");
            }
            return output.ToString().Trim();
        }

        public object Clone()
        {
            Customer newCustomer = new Customer(FirstName, MiddleName, LastName, Id, Address, MobilePhone, Email, Type);
            newCustomer.Payments = new List<Payment>(Payments);
            return newCustomer;
        }

        public int CompareTo(Customer other)
        {
            if(this.FullName == other.FullName)
            {
                return this.Id.CompareTo(other.Id);
            }
            return this.FullName.CompareTo(other.FullName);
        }
    }
}
