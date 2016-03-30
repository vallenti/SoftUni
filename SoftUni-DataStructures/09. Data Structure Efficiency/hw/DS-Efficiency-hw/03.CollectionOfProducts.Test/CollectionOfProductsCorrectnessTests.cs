using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace _03.CollectionOfProducts.Test
{
    [TestClass]
    public class CollectionOfProductsCorrectnessTests
    {
        private ProductsCollection products;

        [TestInitialize]
        public void TestInitialize()
        {
            products = new ProductsCollection();
        }

        [TestMethod]
        public void Add_SeveralElements_ShouldworkCorrectly()
        {
            products.Add("1", "Beer", "Nakov", 1m);
            products.Add("2", "Beer", "Nakov", 1m);
            products.Add("3", "Beer", "Nakov", 1m);
            products.Add("3", "Beer1", "Nakov", 2m);
            Assert.AreEqual(3, products.Count);
        }

        [TestMethod]
        public void Remove_SeveralElements_ShouldworkCorrectly()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Remove_ZeroElements_ShouldThrow()
        {
            products.Remove("10");
        }

        [TestMethod]
        public void FindByPriceRange_MissingResults_ShouldworkCorrectly()
        {
            AddProducts();
            var actual = products.FindByPriceRange(12m, 16m).ToList();
            var expected = new Product[] { };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindByPriceRange_NotMissingResults_ShouldworkCorrectly()
        {
            AddProducts();
            var actual = products.FindByPriceRange(3m, 5.3m).ToList();
            var expected = new Product[]
            {
                new Product("10", "Cheese", "Mandra2", 4.5m),
                new Product("12", "Cucumber", "DD", 3.99m),
                new Product("14", "Rice", "Bg", 3m),
                new Product("2", "Juice", "Nakov", 3m),
                new Product("4", "Magazine", "NG", 5m),
                new Product("6", "Stock", "Suppl2", 3m),
                new Product("7", "Tomato", "Nakov", 5m),
                new Product("9", "Cheese", "Mandra1", 5.2m),
            };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindByTitle_MissingResults_ShouldworkCorrectly()
        {
            AddProducts();
            var missingProduct = products.FindByTitle("MissingProduct").ToList();
            Product[] expected = new Product[] { };
            CollectionAssert.AreEqual(expected, missingProduct);
        }

        [TestMethod]
        public void FindByTitle_NotMissingResults_ShouldworkCorrectly()
        {
            AddProducts();
            var actualProducts = products.FindByTitle("Cheese").ToList();
            Product[] expected = new Product[]
            {
                new Product("10", "Cheese", "Mandra2", 4.5m),
                new Product("8", "Cheese", "Mandra1", 1.2m),
                new Product("9", "Cheese", "Mandra1", 5.2m),
            };
            CollectionAssert.AreEqual(expected, actualProducts);
        }

        [TestMethod]
        public void FindByTitleAndPrice_MissingResults_ShouldworkCorrectly()
        {
            AddProducts();
            var missingProducts = products.FindByTitleAndPrice("NotBeer", 2.5m).ToList();
            var expected = new Product[] { };
            CollectionAssert.AreEqual(expected, missingProducts);
        }

        [TestMethod]
        public void FindByTitleAndPrice_NotMissingResults_ShouldworkCorrectly()
        {
            AddProducts();
            var actualProducts = products.FindByTitleAndPrice("Stock", 2m).ToList();
            var expected = new Product[]
            {
                new Product("0", "Stock", "Supl", 2m),
                new Product("5", "Stock", "Suppl1", 2m)
            };

            CollectionAssert.AreEqual(expected, actualProducts);
        }

        [TestMethod]
        public void FindByTitleAndPriceRange_MissingResults_ShouldworkCorrectly()
        {
            AddProducts();
            var actual = products.FindByTitleAndPriceRange("None", 1.1m, 2.0m).ToList();
            var expected = new Product[] { };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindByTitleAndPriceRange_NotMissingResults_ShouldworkCorrectly()
        {
            AddProducts();
            var actual = products.FindByTitleAndPriceRange("Cheese", 1m, 5m).ToList();
            var expected = new Product[] {
                new Product("10", "Cheese", "Mandra2", 4.5m),
                new Product("8", "Cheese", "Mandra1", 1.2m),
            };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindBySupplierAndPrice_MissingResults_ShouldworkCorrectly()
        {
            AddProducts();
            var missingProducts = products.FindBySupplierAndPrice("NotNakov", 2.5m).ToList();
            var expected = new Product[] { };
            CollectionAssert.AreEqual(expected, missingProducts);
        }

        [TestMethod]
        public void FindBySupplierAndPrice_NotMissingResults_ShouldworkCorrectly()
        {
            AddProducts();
            var actualProducts = products.FindBySupplierAndPrice("Nakov", 1m).ToList();
            var expected = new Product[]
            {
                new Product("1", "Beer", "Nakov", 1m),
                new Product("16", "BBB", "Nakov", 1m)
            };

            CollectionAssert.AreEqual(expected, actualProducts);
        }

        [TestMethod]
        public void FindBySupplierAndPriceRange_MissingResults_ShouldworkCorrectly()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void FindBySupplierAndPriceRange_NotMissingResults_ShouldworkCorrectly()
        {
            throw new NotImplementedException();
        }

        private void AddProducts()
        {
            products.Add("1", "Beer", "Nakov", 1m);
            products.Add("2", "Juice", "Nakov", 3m);
            products.Add("3", "Juice", "Nakov", 2m);
            products.Add("4", "Magazine", "NG", 5m);
            products.Add("5", "Stock", "Suppl1", 2m);
            products.Add("6", "Stock", "Suppl2", 3m);
            products.Add("7", "Tomato", "Nakov", 5m);
            products.Add("8", "Cheese", "Mandra1", 1.2m);
            products.Add("9", "Cheese", "Mandra1", 5.2m);
            products.Add("10", "Cheese", "Mandra2", 4.5m);
            products.Add("11", "Soup", "Gotv", 1.6m);
            products.Add("12", "Cucumber", "DD", 3.99m);
            products.Add("13", "Rice", "China", 1.5m);
            products.Add("14", "Rice", "Bg", 3m);
            products.Add("15", "Oil", "Italy", 2.6m);
            products.Add("0", "Stock", "Supl", 2m);
            products.Add("16", "BBB", "Nakov", 1m);
        }
    }
}
