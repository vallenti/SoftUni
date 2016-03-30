namespace _01.ProductsInPriceRange
{
    using System;

    public class Product : IComparable
    {
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CompareTo(object obj)
        {
            var other = obj as Product;
            return this.Price.CompareTo(other.Price);
        }
    }
}
