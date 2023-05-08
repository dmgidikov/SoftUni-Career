namespace _05._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sizes = ParseFromConsole();

            var rows = sizes[0];
            var cols = sizes[1];

            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var input = ParseFromConsole();

                for (int col = 0; col < cols; col++)
                {
                    var currentElement = input[col];
                    matrix[row, col] = currentElement;
                }
            }

            var maxSum = int.MinValue;
            var maxRow = -1;
            var maxCol = -1;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    var first = matrix[row, col];
                    var secod = matrix[row, col + 1];

                    var third = matrix[row + 1, col];
                    var fourth = matrix[row + 1, col + 1];

                    var currentSum = first + secod + third + fourth;

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
            Console.WriteLine(maxSum);

        }

        private static List<int> ParseFromConsole()
        {
            return Console.ReadLine().Split(", ").Select(int.Parse).ToList();
        }
    }
}