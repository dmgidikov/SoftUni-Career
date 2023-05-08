namespace _04._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var sortedNums = nums.OrderByDescending(x => x).ToArray();

            if (sortedNums.Length < 3)
            {
                foreach (var num in sortedNums)
                {
                    Console.Write($"{num} ");
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(sortedNums[i] + " ");
                }
            }
        }
    }
}