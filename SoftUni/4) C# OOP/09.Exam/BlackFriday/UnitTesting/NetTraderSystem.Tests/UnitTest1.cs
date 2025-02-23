using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace NetTraderSystem.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestConstructorInitializingEmpty()
        {
            var inventoryLimit = 5;
            var tradingPlatform = new TradingPlatform(inventoryLimit);

            Assert.NotNull(tradingPlatform.Products, "Products collection must not be 0");
        }

        [Test]
        public void TestConstructorLimit()
        {
            var inventoryLimit = 1;
            var product1 = new Product("Product1", "Category1", 1);
            var product2 = new Product("Product2", "Category2", 2);

            var platform = new TradingPlatform(inventoryLimit);
            platform.AddProduct(product1);

            var result = platform.AddProduct(product2);

            Assert.That(result, Is.EqualTo("Inventory is full"));
            Assert.AreEqual(platform.Products.Count, inventoryLimit);
        }

        [Test]
        public void TestAddProduct()
        {
            var inventoryLimit = 1;
            var product = new Product("Product1", "Category1", 1);
            var platform = new TradingPlatform(inventoryLimit);

            platform.AddProduct(product);

            var productFromPlatform = platform.Products.FirstOrDefault(x => x.Name == "Prodcut1");
            Assert.That(platform.Products.Count, Is.EqualTo(1));
            Assert.That(productFromPlatform, Is.EqualTo(product));
        }
    }
}