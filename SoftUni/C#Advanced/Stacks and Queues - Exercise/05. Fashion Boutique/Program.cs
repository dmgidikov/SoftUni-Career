namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var randomNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var capacity = int.Parse(Console.ReadLine());

            var stack = new Stack<int>(randomNums);
            var counter = 1;
            var capacityCopy = capacity;

            while (stack.Any())
            {
                var firstNum = stack.Peek();

                if (capacityCopy - firstNum >= 0)
                {
                    capacityCopy -= firstNum;
                    stack.Pop();
                }
                else
                {
                    counter++;
                    capacityCopy = capacity;
                }
            }

            Console.WriteLine(counter);
        }
    }
}