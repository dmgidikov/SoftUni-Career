namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main()
        {
            var persons = new List<Person>();

            var people = int.Parse(Console.ReadLine());

            for (int i = 0; i < people; i++)
            {
                var peopleInfo = Console.ReadLine().Split();
                
                try
                {
                    var person = new Person(
                        peopleInfo[0],
                        peopleInfo[1],
                        int.Parse(peopleInfo[2]),
                        decimal.Parse(peopleInfo[3]));

                    persons.Add(person);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}