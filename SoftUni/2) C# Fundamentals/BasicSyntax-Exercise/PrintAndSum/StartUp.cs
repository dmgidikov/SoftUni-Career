namespace PrintAndSum
{
    public class StartUp
    {
        public static void Main()
        {
            var start = int.Parse(Console.ReadLine());
            var end  = int.Parse(Console.ReadLine());

            var sum = 0;

            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
