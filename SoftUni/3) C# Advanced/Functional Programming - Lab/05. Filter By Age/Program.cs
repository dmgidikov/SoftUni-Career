namespace _05._Filter_By_Age
{
    public class Program
    {
        static void Main(string[] args)
        {
            var rotations = int.Parse(Console.ReadLine());

            var cats = new List<Cat>();

            for (int i = 0; i < rotations; i++)
            {
                var temp = Console.ReadLine().Split(", ");

                var cat = new Cat
                {
                    Name = temp[0],
                    Age = int.Parse(temp[1])
                };

                cats.Add(cat);
            }

            var command = Console.ReadLine();
            var filterAge = int.Parse(Console.ReadLine());

            Func<Cat, bool> filter = command switch
            {
                "older" => c => c.Age >= filterAge,
                "younger" => c => c.Age < filterAge,
                _ => c => true
            };

            var output = Console.ReadLine();

            Func<Cat, string> filterOutput = output switch
            {
                "name age" => c => $"{c.Name} - {c.Age}",
                "name" => c => $"{c.Name}",
                "age" => c => $"{c.Age}",
                _ => null
            };

            cats
                .Where(filter)
                .Select(filterOutput)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }

    public class Cat
    {
        public string Name { get; set; } 
        public int Age { get; set; }
    }
}