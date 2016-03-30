using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _03.CollectionOfProducts
{
    public class ProductsCollection
    {
        Dictionary<string, Product> productsById;
        Dictionary<string, SortedSet<Product>> productsByTitle;
        Dictionary<string, SortedSet<Product>> productsByTitleAndPrice;
        Dictionary<string, SortedSet<Product>> productsBySupplierAndPrice;
        OrderedDictionary<decimal, OrderedBag<Product>> productsByPriceRange;
        Dictionary<string, OrderedDictionary<decimal, OrderedBag<Product>>> productsByTitleAndPriceRange;
        Dictionary<string, OrderedDictionary<decimal, OrderedBag<Product>>> productsBySupplierAndPriceRange;
        

        public ProductsCollection()
        {
            this.productsById = new Dictionary<string, Product>();
            this.productsByTitle = new Dictionary<string, SortedSet<Product>>();
            this.productsByTitleAndPrice = new Dictionary<string, SortedSet<Product>>();
            this.productsBySupplierAndPrice = new Dictionary<string, SortedSet<Product>>();
            this.productsByPriceRange = new OrderedDictionary<decimal, OrderedBag<Product>>();
            this.productsByTitleAndPriceRange = new Dictionary<string, OrderedDictionary<decimal, OrderedBag<Product>>>();
            this.productsBySupplierAndPriceRange = new Dictionary<string, OrderedDictionary<decimal, OrderedBag<Product>>>();
        }

        public int Count
        {
            get
            {
                return this.productsById.Count;
            }
        }

        public void Add(string id, string title, string supplier, decimal price)
        {
            var product = new Product(id, title, supplier, price);
            var titleAndPriceKey = title + "|!|" + price;
            var supplierAndPriceKey = supplier + "|!!|" + price;
            if(!productsById.ContainsKey(id))
            {
                productsById[id] = product;
            }

            if(!productsByTitle.ContainsKey(title))
            {
                productsByTitle.Add(title, new SortedSet<Product>());
            }

            if(!productsByTitleAndPrice.ContainsKey(titleAndPriceKey))
            {
                productsByTitleAndPrice.Add(titleAndPriceKey, new SortedSet<Product>());
            }

            if(!productsBySupplierAndPrice.ContainsKey(supplierAndPriceKey))
            {
                productsBySupplierAndPrice.Add(supplierAndPriceKey, new SortedSet<Product>());
            }

            if(!productsByPriceRange.ContainsKey(price))
            {
                productsByPriceRange[price] = new OrderedBag<Product>();
            }

            if(!productsByTitleAndPriceRange.ContainsKey(title))
            {
                productsByTitleAndPriceRange[title] = new OrderedDictionary<decimal, OrderedBag<Product>>();
            }
            if(!productsByTitleAndPriceRange[title].ContainsKey(price))
            {
                productsByTitleAndPriceRange[title][price] = new OrderedBag<Product>();
            }

            if(!productsBySupplierAndPriceRange.ContainsKey(supplier))
            {
                productsBySupplierAndPriceRange[supplier] = new OrderedDictionary<decimal, OrderedBag<Product>>();
            }

            if(!productsBySupplierAndPriceRange[supplier].ContainsKey(price))
            {
                productsBySupplierAndPriceRange[supplier][price] = new OrderedBag<Product>();
            }


            productsById[id] = product;
            productsByTitle[title].Add(product);
            productsByTitleAndPrice[titleAndPriceKey].Add(product);
            productsBySupplierAndPrice[supplierAndPriceKey].Add(product);

            productsByPriceRange[price].Add(product);
            productsByTitleAndPriceRange[title][price].Add(product);
            productsBySupplierAndPriceRange[supplier][price].Add(product);
        }

        public bool Remove(string id)
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("Cannot remove from empty collection");
            }

            if(!productsById.ContainsKey(id))
            {
                return false;
            }
            var product = productsById[id];
            
            //TODO remove from rest of collections

            return true;
        }

        public IEnumerable<Product> FindByPriceRange(decimal from, decimal to)
        {
            var productsInRange = productsByPriceRange.Range(from, true, to, true);
            var result = productsInRange.SelectMany(x => x.Value).ToArray();
            Array.Sort(result);
            return result;
        }

        public IEnumerable<Product> FindByTitle(string title)
        {
            if(!productsByTitle.ContainsKey(title))
            {
                return Enumerable.Empty<Product>();
            }

            return productsByTitle[title];

        }

        public IEnumerable<Product> FindByTitleAndPrice(string title, decimal price)
        {
            var titleAndPriceKey = title + "|!|" + price;
            if (!productsByTitleAndPrice.ContainsKey(titleAndPriceKey))
            {
                return Enumerable.Empty<Product>();
            }

            return productsByTitleAndPrice[titleAndPriceKey];

        }

        public IEnumerable<Product> FindByTitleAndPriceRange(string title, decimal start, decimal end)
        {
            if(!productsByTitleAndPriceRange.ContainsKey(title))
            {
                return Enumerable.Empty<Product>();
            }

            var productsInRange = productsByTitleAndPriceRange[title].Range(start, true, end, true);
            var result = productsInRange.SelectMany(x => x.Value).ToArray();
            Array.Sort(result);
            return result;

        }

        public IEnumerable<Product> FindBySupplierAndPrice(string supplier, decimal price)
        {
            var supplierAndPriceKey = supplier + "|!!|" + price;
            if(!productsBySupplierAndPrice.ContainsKey(supplierAndPriceKey))
            {
                return Enumerable.Empty<Product>();
            }

            return productsBySupplierAndPrice[supplierAndPriceKey];
        }

        public IEnumerable<Product> FindBySupplierAndPriceRange(string supplier, decimal start, decimal end)
        {
            if(!productsBySupplierAndPriceRange.ContainsKey(supplier))
            {
                return Enumerable.Empty<Product>();
            }

            var productsInRange = productsBySupplierAndPriceRange[supplier].Range(start, true, end, true);
            var result = productsInRange.SelectMany(x => x.Value).ToArray();
            Array.Sort(result);
            return result;
        }


    }
}
