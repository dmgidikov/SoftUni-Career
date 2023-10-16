namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lenghts = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var firstSetLenght = lenghts.First();
            var secondSetLenght = lenghts.Last();

            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            for (int i = 0; i < firstSetLenght; i++)
            {
                int randomNum = ParseFromConsole();
                firstSet.Add(randomNum);
            }

            for (int i = 0; i < secondSetLenght; i++)
            {
                int randomNum = ParseFromConsole();
                secondSet.Add(randomNum);
            }

            firstSet.IntersectWith(secondSet);

            Console.WriteLine(string.Join(" ", firstSet));
        }

        private static int ParseFromConsole()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}