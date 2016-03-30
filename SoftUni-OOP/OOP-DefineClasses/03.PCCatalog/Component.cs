using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PCCatalog
{
    class Component
    {
        private string name;
        private decimal price;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(value == String.Empty)
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public string Details { get; set; }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Price cannot be negative");
                }
                this.price = value;
            }
        }

        public Component(string name, decimal price)
            : this(name, price, null)
        {
        }

        public Component(string name, decimal price, string details)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }
    }
}
