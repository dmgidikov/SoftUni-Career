using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.Models;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (var db = new ProductShopContext())
            {
                var inputJson = File.ReadAllText("./../../../Datasets/categories-products.json");

                var result = GetUsersWithProducts(db);

                Console.WriteLine(result);
            }
        }

        // Query 1. Import Users
        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            var users = JsonConvert.DeserializeObject<List<User>>(inputJson);

            context.Users.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {users.Count}";
        }

        // Query 2. Import Products
        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            var products = JsonConvert.DeserializeObject<List<Product>>(inputJson);

            context.Products.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Count}";
        }

        // Query 3. Import Categories
        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            var categories = JsonConvert.DeserializeObject<List<Category>>(inputJson);

            context.Categories.AddRange(categories);
            context.SaveChanges();

            return $"Successfully imported {categories.Count}";
        }

        // Query 4. Import Categories and Products
        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            var categoriesProducts = JsonConvert.DeserializeObject<List<CategoryProduct>>(inputJson);

            context.CategoryProducts.AddRange(categoriesProducts);
            context.SaveChanges();

            return $"Successfully imported {categoriesProducts.Count}";
        }

        // Query 5. Export Products In Range
        public static string GetProductsInRange(ProductShopContext context)
        {
            var producsts = context
                .Products
                .Where(x => x.Price >= 500 && x.Price <= 1000)
                .OrderBy(x => x.Price)
                .Select(x => new
                {
                    name = x.Name,
                    price = Math.Round(x.Price, 2),
                    seller = x.Seller.FirstName + " " + x.Seller.LastName,
                })
                .ToList();

            var result = JsonConvert.SerializeObject(producsts, Formatting.Indented);

            return result;
        }

        // Query 6. Export Successfully Sold Products
        public static string GetSoldProducts(ProductShopContext context)
        {
            var buyersAndSellersInfo = context
                .Products
                .Where(x => x.Seller.ProductsSold.Any())
                .OrderBy(x => x.Seller.LastName)
                .ThenBy(x => x.Seller.LastName)
                .Select(x => new
                {
                    firstName = x.Seller.FirstName,
                    lastName = x.Seller.LastName,
                    soldProducts = new
                    {
                        name = x.Name,
                        price = x.Price,
                        buyerFirstName = x.Buyer.FirstName,
                        buyerLastName = x.Buyer.LastName,
                    }
                })
                .ToList();

            var result = JsonConvert.SerializeObject(buyersAndSellersInfo, Formatting.Indented);

            return result;
        }

        // Query 7. Export Categories By Products Count
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categoriesCount = context
                .Categories
                .OrderByDescending(x => x.CategoryProducts.Count())
                .Select(x => new
                {
                    category = x.Name,
                    productsCount = x.CategoryProducts.Count,
                    avaragePrice = (x.CategoryProducts.Average(x => x.Product.Price)).ToString("f2"),
                    totalRevenue = (x.CategoryProducts.Count * x.CategoryProducts.Average(x => x.Product.Price)).ToString("f2"),
                })
                .ToList();

            var result = JsonConvert.SerializeObject(categoriesCount, Formatting.Indented);

            return result;
        }

        // Query 8. Export Users and Products
        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var buyersAndSellersInfo = context
               .Users
               .Where(x => x.ProductsSold.Any())
               .OrderByDescending(x => x.ProductsSold.Count())
               .Select(x => new
               {                  
                   firstName = x.FirstName,
                   lastName = x.LastName,
                   age = x.Age,
                   soldProducts = new
                   {
                       count = x.ProductsSold.Count,
                       products = x.ProductsSold
                                .Select(x => new
                                {
                                    name = x.Name,
                                    price = x.Price
                                })
                   }


               })
               .ToList();

            var usercOutput = new
            {
                usersCount = buyersAndSellersInfo.Count,
                users = buyersAndSellersInfo
            };

            var result = JsonConvert.SerializeObject(usercOutput, new
                JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore,
            });

            return result;
        }
    }
}