namespace _04._Add_VAT
{
    public class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .Select(x => x * 1.2)
                .ToArray();

            foreach (var num in nums)
            {
                Console.WriteLine($"{num:f2}");
            }
        }
    }
}
