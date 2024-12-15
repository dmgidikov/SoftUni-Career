namespace _01.SortPersonByNameAndAge
{
    public class StartUp
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());  

            var people = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                var args = Console.ReadLine().Split();

                var firstName = args[0];
                var lastName = args[1];
                var age = int.Parse(args[2]);

                var person = new Person(firstName, lastName, age);
                people.Add(person);
            }

            people.OrderBy(p => p.FirstName)
                .ThenBy(p => p.LastName)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}