namespace _03_ValidationOfData
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
                var salary = decimal.Parse(args[3]);

                var person = new Person(firstName, lastName, age, salary);
                people.Add(person);
            }

            var salaryIncreasePercentage = decimal.Parse(Console.ReadLine());

            people.ForEach(p => p.IncreaseSalary(salaryIncreasePercentage));
            people.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}