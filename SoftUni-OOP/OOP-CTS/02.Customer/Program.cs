using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer a = new Customer("Pesho", "Peshev", "Peshev", "123456789", "Sofiata", "+359231344", "pesho@p.bg", CustomerType.Regular);
            Customer b = new Customer("Gosho", "Goshev", "Goshev", "987654321", "Varnata", "+359231353", "gosho@g.bg", CustomerType.Diamond);
            Customer c = new Customer("Gosho", "Goshev", "Goshev", "887654321", "Varnata", "+359231353", "gosho@g.bg", CustomerType.Diamond);
            a.AddPayment(new Payment("Slanina", 6.6m));
            a.AddPayment(new Payment("Bob", 4.20m));
            Console.WriteLine(a);
            Console.WriteLine();
            Console.WriteLine(b);
            Console.WriteLine();

            //Implemented ICloneable
            Customer d = a.Clone() as Customer;
            d.FirstName = "Pesho2";
            d.AddPayment(new Payment("Chushki",1.20m));
            Console.WriteLine(a);
            Console.WriteLine();
            Console.WriteLine(d);

            //Implemented IComparable<Customer>
            List<Customer> list = new List<Customer>(){ a, b, c, d };
            Console.WriteLine("Unsorted:");
            list.ForEach(x => Console.WriteLine(x.FullName + " " + x.Id));
            list.Sort();
            Console.WriteLine("Sorted:");
            list.ForEach(x => Console.WriteLine(x.FullName + " " + x.Id));
        }
    }
}
