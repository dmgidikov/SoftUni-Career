









namespace ShopHierarchy
{
    public class Program
    {
        public static void Main()
        {
            using (var db = new SalesDbContext())
            {
                ClearDatabase(db);
                FillSalesmanWithData(db);
                FillItemsWithData(db);

                ReadCommands(db);
                PrintNumberOfItems(db);
            }
        }


        private static void ClearDatabase(SalesDbContext db)
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
        }

        private static void FillSalesmanWithData(SalesDbContext db)
        {
            var input = Console.ReadLine().Split(";").ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                var salesman = new SalesMan()
                {
                    Name = input[i],
                };

                db.SalesMen.Add(salesman);
            }

            db.SaveChanges();
        }

        private static void FillItemsWithData(SalesDbContext db)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                var args = input.Split(";");

                var itemName = args[0];
                var itemPrice = decimal.Parse(args[1]);

                var item = new Item
                {
                    Name = itemName,
                    Price = itemPrice,
                };

                db.Add(item);
                db.SaveChanges();
            }
        }

        private static void ReadCommands(SalesDbContext db)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                var args = input.Split("-");

                var command = args[0];

                switch (command)
                {
                    case "register":
                        ReadCustomersInfo(db, args[1]); break;
                    case "order":
                        ReadOrderInfo(db, args[1]); break;
                    case "review":
                        ReadReviewInfo(db, args[1]); break;
                    default:
                        break;
                }
            }
        }

        private static void ReadCustomersInfo(SalesDbContext db, string args)
        {
            var data = args.Split(";");

            var customerName = data[0];
            var salesManId = int.Parse(data[1]);

            var customer = new Customer()
            {
                SalesmanId = salesManId,
                Name = customerName
            };

            db.Customers.Add(customer);
            db.SaveChanges();
        }

        private static void ReadOrderInfo(SalesDbContext db, string arg)
        {
            var args = arg.Split(";");

            var customerId = int.Parse(args[0]);

            var order = new Order()
            {
                CustomerId = customerId,
                Items = new List<OrderItem>()
            };

            for (int i = 1; i < args.Length; i++)
            {
                var item = new OrderItem()
                {
                    OrderId = order.Id,
                    ItemId = int.Parse(args[i])
                };

                order.Items.Add(item);
            }


            db.Add(order);
            db.SaveChanges();
        }

        private static void ReadReviewInfo(SalesDbContext db, string arg)
        {
            var args = arg.Split(";");

            var customerId = int.Parse(args[0]);
            var itemId = int.Parse(args[0]);

            var review = new Review()
            {
                CustomerId = customerId,
                ItemId = itemId,
            };

            db.Add(review);
            db.SaveChanges();
        }


        private static void PrintAllSalesManInfo(SalesDbContext db)
        {
            var salesman = db.SalesMen
                .Select(x => new
                {
                    Name = x.Name,
                    Customers = x.Customers.Count,
                })
                .OrderByDescending(x => x.Customers)
                .ThenBy(x => x.Name)
                .ToList();

            foreach (var man in salesman)
            {
                Console.WriteLine($"{man.Name} - {man.Customers} customers");
            }
        }

        private static void PrintCusomersDetails(SalesDbContext db)
        {
            var result = db
                .Customers
                .Select(c => new
                {
                    Name = c.Name,
                    Orders = c.Orders.Count,
                    Reviews = c.Reviews.Count,
                })
                .OrderByDescending(x => x.Orders)
                .ThenBy(x => x.Reviews)
                .ToList();

            foreach (var info in result)
            {
                Console.WriteLine($"{info.Name}");
                Console.WriteLine($"Orders: {info.Orders}");
                Console.WriteLine($"Reviews: {info.Reviews}");
            }
        }

        private static void PrintNumberOfItems(SalesDbContext db)
        {
            var customerId = int.Parse(Console.ReadLine());

            var customer = db.Customers
                .Where(x => x.Id == customerId)
                .Select(x => new
                {
                    Name = x.Name,
                    Orders = x.Orders,
                    Reviews = x.Reviews,
                    Salesman = x.SalesMan.Name
                })
                .FirstOrDefault();

            Console.WriteLine($"Customer: {customer.Name}");
            Console.WriteLine($"Orders: {customer.Orders.Count}");
            Console.WriteLine($"Reviews: {customer.Reviews.Count}");
            Console.WriteLine($"Salesman: {customer.Salesman}");
        }
    }
}
