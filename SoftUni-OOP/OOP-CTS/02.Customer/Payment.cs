﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Customer
{
    class Payment
    {
        public Payment(string productName, decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
        }

        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return String.Format("{0} - {1:f2} lv.", ProductName, Price);
        }
    }
}
