namespace SumOfOddNums
{
    public class StartUp
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 1; i < num * 2; i += 2)
            {
                Console.WriteLine(i);
                sum += i;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
