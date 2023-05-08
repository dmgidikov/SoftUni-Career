namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rotations = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < rotations; i++)
            {
                var input = Console.ReadLine().Split(" -> ");

                var color = input[0].Trim();
                var clothes = input[1].Split(",");

                if (wardrobe.ContainsKey(color) == false)
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                foreach (var cloth in clothes)
                {
                    if (wardrobe[color].ContainsKey(cloth) == false)
                    {
                        wardrobe[color][cloth] = 0;
                    }

                    wardrobe[color][cloth]++;
                }
            }

            var searchingForCloth = Console.ReadLine().Split(" ");

            var searchingColor = searchingForCloth[0].Trim();
            var searchingType = searchingForCloth[1].Trim();

            foreach (var kvp in wardrobe)
            {
                var color = kvp.Key;
                var clothesInfo = kvp.Value;

                if (color == searchingColor)
                {
                    Console.WriteLine($"{color} clothes:");

                    foreach (var (cloth, quantity) in clothesInfo)
                    {
                        if (cloth == searchingType)
                        {
                            Console.WriteLine($"* {cloth} - {quantity} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {cloth} - {quantity}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"{color} clothes:");

                    foreach (var (cloth, quantity) in clothesInfo)
                    {
                        Console.WriteLine($"* {cloth} - {quantity}");
                    }
                }
            }
        }
    }
}