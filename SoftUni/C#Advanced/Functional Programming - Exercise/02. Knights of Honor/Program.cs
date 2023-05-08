namespace _02._Knights_of_Honor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Action<string> printHonor = x => Console.WriteLine($"Sir " + x);

            var names = Console.ReadLine().Split();

            foreach (var name in names)
            {
                printHonor(name);
            }
        }
    }
}