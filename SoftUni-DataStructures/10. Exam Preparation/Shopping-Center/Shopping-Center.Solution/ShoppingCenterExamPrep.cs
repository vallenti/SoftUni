using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

public class ShoppingCenterExamPrep
{
    private const string ProductAdded = "Product added";
    private const string XProductsDeleted = " products deleted";
    private const string NoProductsFound = "No products found";
    private const string IncorrectCommand = "Incorrect command";

    private MultiDictionary<string, Product> productsByName = new MultiDictionary<string, Product>(true);
    private MultiDictionary<string, Product> productsByProducer = new MultiDictionary<string, Product>(true);
    private OrderedMultiDictionary<decimal, Product> productsByPrice = new OrderedMultiDictionary<decimal, Product>(true);
    private MultiDictionary<string, Product> productsByNameAndProducer = new MultiDictionary<string, Product>(true);

    public string AddProduct(string name, decimal price, string producer)
    {
        var product = new Product(name, producer, price);
        var nameProducerKey = name + ";;;" + producer;

        productsByName[name].Add(product);
        productsByProducer[producer].Add(product);
        productsByPrice[price].Add(product);
        productsByNameAndProducer[nameProducerKey].Add(product);

        return ProductAdded;
    }

    public string FindProductsByName(string name)
    {
        var productsFound = this.productsByName[name];
        return SortAndPrintProducts(productsFound);
    }

    private string SortAndPrintProducts(IEnumerable<Product> products)
    {
        if (products.Any())
        {
            var sortedProducts = new List<Product>(products);
            sortedProducts.Sort();
            var builder = new StringBuilder();
            foreach (var product in sortedProducts)
            {
                builder.AppendLine(product.ToString());
            }

            // Remove the undneeded last "new line"
            builder.Length -= Environment.NewLine.Length;

            string formattedProducts = builder.ToString();
            return formattedProducts;
        }

        return NoProductsFound;
    }


    public string FindProductsByProducer(string producer)
    {
        var productsFound = this.productsByProducer[producer];
        return SortAndPrintProducts(productsFound);

    }

    public string FindProductsByPriceRange(
        decimal startPrice, decimal endPrice)
    {
        var productsInRange = productsByPrice.Range(startPrice, true, endPrice, true);
        if(!productsInRange.Values.Any())
        {
            return NoProductsFound;
        }

        var bag = new OrderedBag<Product>();
        foreach (var product in productsInRange.Values)
        {
                bag.Add(product);
        }

        return string.Join(Environment.NewLine, bag);
    }

    public string DeleteProductsByProducer(string producer)
    {
        if(!productsByProducer.ContainsKey(producer))
        {
            return NoProductsFound;
        }

        int removedProducts = productsByProducer[producer].Count;
        foreach (var removeProduct in productsByProducer[producer])
        {
            var name = removeProduct.Name;
            var price = removeProduct.Price;
            productsByName[name].Remove(removeProduct);
            if(productsByName[name].Count == 0)
            {
                productsByName.Remove(name);
            }
            productsByPrice[price].Remove(removeProduct);
            productsByNameAndProducer.Remove(name + ";;;" + producer);
        }


        productsByProducer.Remove(producer);

        return removedProducts + XProductsDeleted;
    }

    public string DeleteProductsByNameAndProducer(
        string name, string producer)
    {
        var key = name + ";;;" + producer;
        if (!productsByNameAndProducer.ContainsKey(key))
        {
            return NoProductsFound;
        }

        var removedProducts = productsByNameAndProducer[key].Count;
        var removeCollection = productsByNameAndProducer[key];
        foreach (var product in removeCollection)
        {
            productsByName[product.Name].Remove(product);
            if(productsByName[product.Name].Count == 0)
            {
                productsByName.Remove(product.Name);
            }
            productsByProducer[product.Producer].Remove(product);
            productsByPrice[product.Price].Remove(product);
        }

        productsByNameAndProducer.Remove(key);

        return removedProducts + XProductsDeleted;
    }

    public string ProcessCommand(string commandLine)
    {
        int spaceIndex = commandLine.IndexOf(' ');
        if (spaceIndex == -1)
        {
            return "Invalid command";
        }

        string command = commandLine.Substring(0, spaceIndex);
        string paramsStr = commandLine.Substring(spaceIndex + 1);
        string[] cmdParams = paramsStr.Split(';');
        switch (command)
        {
            case "AddProduct":
                return this.AddProduct(
                    cmdParams[0], decimal.Parse(cmdParams[1]), cmdParams[2]);
            case "DeleteProducts":
                if (cmdParams.Length == 1)
                    return this.DeleteProductsByProducer(
                        cmdParams[0]);
                else
                    return this.DeleteProductsByNameAndProducer(
                        cmdParams[0], cmdParams[1]);
            case "FindProductsByName":
                return this.FindProductsByName(cmdParams[0]);
            case "FindProductsByProducer":
                return this.FindProductsByProducer(cmdParams[0]);
            case "FindProductsByPriceRange":
                return this.FindProductsByPriceRange(
                    decimal.Parse(cmdParams[0]), decimal.Parse(cmdParams[1]));
            default:
                return "Invalid command";
        }
    }
}
