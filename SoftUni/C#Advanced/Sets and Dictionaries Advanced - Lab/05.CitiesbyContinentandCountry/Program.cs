namespace _05.CitiesbyContinentandCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rotations = int.Parse(Console.ReadLine());

            var cityByContinentAndCountry = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < rotations; i++)
            {
                var input = Console.ReadLine().Split();

                var continent = input[0];
                var country = input[1];
                var city = input[2];

                if (cityByContinentAndCountry.ContainsKey(continent) == false)
                {
                    cityByContinentAndCountry[continent] = new Dictionary<string, List<string>>();
                }

                if (cityByContinentAndCountry[continent].ContainsKey(country) == false)
                {
                    cityByContinentAndCountry[continent][country] = new List<string>();
                }

                cityByContinentAndCountry[continent][country].Add(city);
            }

            foreach (var (continent, countryInfo) in cityByContinentAndCountry)
            {
                Console.WriteLine($"{continent}:");

                foreach (var (country, town) in countryInfo)
                {
                    Console.Write($"{country} -> ");
                    Console.Write($"{string.Join(", ", town)}");
                    Console.WriteLine();
                }
            }
        }
    }
}