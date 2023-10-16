namespace _04._Find_Evens_or_Odds
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split();

            var start = int.Parse(nums[0]);
            var end = int.Parse(nums[1]);

            var command = Console.ReadLine();

            if (command == "odd")
            {
                for (int i = start; i <= end; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}