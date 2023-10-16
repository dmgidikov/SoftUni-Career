namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shops = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                var input = Console.ReadLine().Split(", ");

                if (input[0] == "Revision")
                {
                    break;
                }
                else
                {
                    var shop = input[0];
                    var product = input[1];
                    var price = double.Parse(input[2]);

                    if (shops.ContainsKey(shop) == false)
                    {
                        shops[shop] = new Dictionary<string, double>();
                    }

                    shops[shop].Add(product, price);
                }
            }

            foreach (var (shop, products) in shops)
            {
                Console.WriteLine($"{shop}->");

                foreach (var productInfo in products)
                {
                    var productName = productInfo.Key;
                    var productPrice = productInfo.Value;

                    Console.WriteLine($"Product: {productName}, Price: {productPrice}");
                }
            }
        }
    }
}