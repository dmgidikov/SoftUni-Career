namespace _02._Sum_Numbers
{
    public class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(nums.Length);
            Console.WriteLine(nums.Sum());
        }
    }
}