namespace EvenNumbersThread
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            var start = int.Parse(input[0]);
            var end = int.Parse(input[1]);

            var evens = new Thread(() => PrintEvenNumbers(start, end));
            evens.Start();
            evens.Join();
            Console.WriteLine("Thread finished work");

        }

        private static void PrintEvenNumbers(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}