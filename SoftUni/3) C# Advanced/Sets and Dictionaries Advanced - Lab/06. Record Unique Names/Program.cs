namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rotations = int.Parse(Console.ReadLine());

            var names = new HashSet<string>();

            for (int i = 0; i < rotations; i++)
            {
                var name = Console.ReadLine();
                names.Add(name);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}