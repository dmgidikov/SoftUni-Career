namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rotations = int.Parse(Console.ReadLine());

            var chemItems = new HashSet<string>();

            for (int i = 0; i < rotations; i++)
            {
                var input = Console.ReadLine().Split();

                foreach (var item in input)
                {
                    chemItems.Add(item);
                }
            }

            var orderedChems = chemItems.OrderBy(x => x);
            Console.WriteLine(string.Join(" ", orderedChems));
        }
    }
}