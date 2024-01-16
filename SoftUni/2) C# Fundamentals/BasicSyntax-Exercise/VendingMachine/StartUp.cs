namespace VendingMachine
{
    public class StartUp
    {
        public static void Main()
        {
            var accpetedCoins = new decimal[]
            {
                0.1m,
                0.2m,
                0.5m,
                1m,
                2m
            };

            var productList = new Dictionary<string, decimal>();
            productList.Add("nuts", 2);
            productList.Add("water", 0.7m);
            productList.Add("crisps", 1.5m);
            productList.Add("soda", 0.8m);
            productList.Add("coke", 1);

            var sum = 0m;

            while (true)
            {
                var input = Console.ReadLine().ToLower();
                var finish = false;

                if (input == "start")
                {
                    while (true)
                    {
                        var product = Console.ReadLine().ToLower();

                        if (product == "end")
                        {
                            finish = true;
                            break;
                        }
                        else
                        {

                            if (productList.ContainsKey(product))
                            {
                                var productPrice = productList[product];

                                if (sum >= productPrice)
                                {
                                    Console.WriteLine($"Purchased {product}");
                                    sum -= productPrice;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid product");
                            }
                        }
                    }                    
                }
                else
                {
                    var coins = decimal.Parse(input);

                    if (accpetedCoins.Contains(coins))
                    {
                        sum += coins;
                    }
                    else
                    {
                        Console.WriteLine($"Cannot accept {coins}");
                    }
                }

                if (finish == true)
                {
                    Console.WriteLine($"Change: {sum:f2}");
                    break;
                }
            }
        }
    }
}
