using System;

class Product : IComparable<Product>
{
    public Product(string name, string producer, decimal price)
    {
        this.Name = name;
        this.Producer = producer;
        this.Price = price;
    }

    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Producer { get; set; }
    public bool IsDeleted { get; set; }

    public override string ToString()
    {
        return string.Format("{{{0};{1};{2:0.00}}}", this.Name, this.Producer, this.Price);
    }

    public int CompareTo(Product other)
    {
        var result = this.Name.CompareTo(other.Name);
        if(result == 0)
        {
            result = this.Producer.CompareTo(other.Producer);
        }

        if(result == 0)
        {
            result = this.Price.CompareTo(other.Price);
        }

        return result;
    }
}