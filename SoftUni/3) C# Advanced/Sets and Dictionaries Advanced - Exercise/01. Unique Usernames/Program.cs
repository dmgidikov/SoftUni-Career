namespace _01._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rotations = int.Parse(Console.ReadLine());

            var uniqueNames = new HashSet<string>();

            for (int i = 0; i < rotations; i++)
            {
                var name = Console.ReadLine();
                uniqueNames.Add(name);
            }

            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}