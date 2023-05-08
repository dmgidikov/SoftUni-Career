namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            var rotations = int.Parse(Console.ReadLine());

            var family = new Family();

            for (int i = 0; i < rotations; i++)
            {
                var input = Console.ReadLine().Split();

                var name = input[0];
                var age = int.Parse(input[1]);

                var person = new Person()
                {
                    Name = name,
                    Age = age
                };

                family.AddMember(person);
            }

            family.PrintMembersOver30s();
        }
    }
}