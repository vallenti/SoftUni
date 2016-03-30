namespace _01.ProductsInPriceRange
{
    using System;
    using Wintellect.PowerCollections;

    public class ProductsCounterLauncher
    {
        static void Main(string[] args)
        {
            OrderedBag<Product> products = new OrderedBag<Product>();
            int productsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < productsCount; i++)
            {
                string[] productEntry = Console.ReadLine().Split();
                string name = productEntry[0];
                decimal price = decimal.Parse(productEntry[1]);
                Product product = new Product(name, price);
                products.Add(product);
            }

            string[] priceRange = Console.ReadLine().Split();
            decimal startPrice = decimal.Parse(priceRange[0]);
            decimal endPrice = decimal.Parse(priceRange[1]);

            var pricesInRange = products.Range(
                new Product(null,startPrice), 
                true,
                new Product(null, endPrice),
                true);

            int maxProductsCount = 20;
            foreach (var product in pricesInRange)
            {
                if (maxProductsCount == 0)
                {
                    break;
                }

                Console.WriteLine(product.Price + " " + product.Name);
                maxProductsCount--; 
            }

        }
    }
}
