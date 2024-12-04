namespace _01.Person
{
    public class StartUp
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            var person = new Person(name, age);
            var child = new Child(name, age);

            Console.WriteLine(person);
            Console.WriteLine(child);
        }
    }
}