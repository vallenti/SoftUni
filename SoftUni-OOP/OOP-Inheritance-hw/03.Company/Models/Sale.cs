using _03.Company.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company
{
    class Sale : ISale
    {

        public Sale(string name, DateTime date, decimal price)
        {
            this.Name = name;
            this.Date = date;
            this.Price = price;
        }

        public string Name{ get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return "+"+this.Name+" "+this.Price+" "+this.Date;
        }
    }
}
