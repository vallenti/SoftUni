using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CollectionOfProducts
{
    public class Product : IComparable<Product>
    {
        public Product(string id, string title = null, string supplier = null, decimal price = 0)
        {
            this.Id = id;
            this.Title = title;
            this.Supplier = supplier;
            this.Price = price;
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Supplier { get; set; }
        public decimal Price { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as Product;
            if(other != null)
            {
                return this.Id.Equals(other.Id);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public int CompareTo(Product other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
}
