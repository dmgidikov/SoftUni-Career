namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Console.ReadLine()
                .Split(new char[] {' ', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => char.IsUpper(x[0]))
                .ToList();

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
        }
    }
}