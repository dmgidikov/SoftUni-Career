namespace _03._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            var matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    var currentElement = input[col];
                    matrix[row, col] = currentElement;
                }
            }

            var sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currentElement = matrix[row, row];
                sum += currentElement;
            }

            Console.WriteLine(sum);
        }
    }
}