namespace ProductShop
{
    using Data;
    using Models;
    using Newtonsoft.Json;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            //var services = new ServiceCollection();

            //services.AddDbContext<ProductShopContext>(options =>
            //    options.UseSqlServer("Server=DESKTOP-KMLVDNC\\SQLEXPRESS;Database=ProductShop;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true"));

            //services.AddAutoMapper(typeof(MappingProfile));

            //var serviceProvider = services.BuildServiceProvider();

            //using (var scope = serviceProvider.CreateScope())
            //{
            //    var context = scope.ServiceProvider.GetRequiredService<ProductShopContext>();
            //    var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

            //    // Step 6: Query example and use AutoMapper to map to DTO
            //    var user = context.Users.FirstOrDefault();
            //    if (user != null)
            //    {
            //        // Mapping User to UserDto using AutoMapper
            //        var userDto = mapper.Map<UserDto>(user);
            //        Console.WriteLine($"Mapped User: {userDto.FullName}");
            //    }

            //    var product = context.Products.FirstOrDefault();
            //    if (product != null)
            //    {
            //        // Mapping Product to ProductDto using AutoMapper
            //        var productDto = mapper.Map<ProductDto>(product);
            //        Console.WriteLine($"Mapped Product: {productDto.SellerFullName} - {productDto.Name}");
            //    }

            using var db = new ProductShopContext();

            var inputJson = File.ReadAllText("./../../../JsonData/categories.json");

            Console.WriteLine(GetCategoriesByProductsCount(db));
        }

        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            var users = JsonConvert.DeserializeObject<List<User>>(inputJson);

            context.AddRange(users);

            return $"Successfully imported {users.Count}";
        }

        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            var products = JsonConvert.DeserializeObject<List<Product>>(inputJson);

            context.AddRange(products);

            return $"Successfully imported {products.Count}";
        }

        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            var categories = JsonConvert.DeserializeObject<List<Category>>(inputJson);

            context.Categories.AddRange(categories);

            return $"Successfully imported {categories.Count}";
        }

        public static string GetProductsInRange(ProductShopContext context)
        {
            var products = context.Products
                .Where(x => x.Price >= 500 && x.Price <= 1000)
                .OrderBy(x => x.Price)
                .Select(x => new
                {
                    Name = x.Name,
                    Price = x.Price,
                    Seller = $"{x.Seller.FirstName} {x.Seller.LastName}",
                })
                .ToList();

            return JsonConvert.SerializeObject(products, Formatting.Indented);
        }

        public static string GetSoldProducts(ProductShopContext context)
        {
            var buyerInfo = context.Users
                .Where(x => x.ProductsSold.Any(x => x.BuyerId != null))
                .OrderBy(x => x.LastName)
                .ThenBy(x => x.FirstName)
                .Select(x => new
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    SoldProducts = x.ProductsSold
                        .Where(x => x.BuyerId != 0)
                        .Select(p => new
                        {
                            Name = p.Name,
                            Price = p.Price,
                            BuyerFirstName = p.Buyer.FirstName,
                            BuyerLastName = p.Buyer.LastName
                        })
                        .ToList()
                })
                .ToList();

            return JsonConvert.SerializeObject(buyerInfo, Formatting.Indented);
        }

        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categories = context.Categories
                .OrderByDescending(x => x.Products.Count)
                .Select(x => new
                {
                    category = x.Name,
                    productsCount = x.Products.Count,
                    avaragePrice = x.Products.Any()
                        ? x.Products.Average(x => x.Price).ToString("F2", CultureInfo.InvariantCulture)
                        : "0:00",
                    totalRevenue = x.Products.Sum(x => x.Price).ToString("F2", CultureInfo.InvariantCulture)
                })
                .ToList();

            return JsonConvert.SerializeObject(categories, Formatting.Indented);
        }
    }
}