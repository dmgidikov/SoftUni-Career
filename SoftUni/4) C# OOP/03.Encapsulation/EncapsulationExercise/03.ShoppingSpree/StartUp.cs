namespace ShoppingSpree
{
    public class StartUp
    {
        public static void Main()
        {
            var peopleArgs = Console.ReadLine().Split(";");

            var people = new List<Person>();

            for (int i = 0; i < peopleArgs.Length; i++)
            {
                var temp = peopleArgs[i].Split("=");

                var personName = temp[0];
                var personAge = int.Parse(temp[1]);

                var person = new Person(personName, personAge);
                people.Add(person);
            }

            var productArgs = Console.ReadLine().Split(";");

            var products = new List<Product>();

            for (int i = 0; i < productArgs.Length; i++)
            {
                var temp = productArgs[i].Split("=");

                var productName = temp[0];
                var productPrice = decimal.Parse(temp[1]);

                var product = new Product(productName, productPrice);
                products.Add(product);
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                var command = input.Split();

                var filterPersonName = command[0];
                var filterProductName = command[1];

                var tempPerson = people.FirstOrDefault(x => x.Name == filterPersonName);  
                var tempProduct = products.FirstOrDefault(x => x.Name == filterProductName);

                tempPerson.BuyProduct(tempProduct);
            }
        }
    }
}