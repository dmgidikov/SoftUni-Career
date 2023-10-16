namespace _02._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ParseFromConsole(' ', ',');

            var rows = sizes[0];
            var cols = sizes[1];

            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var input = ParseFromConsole(' ');

                for (int col = 0; col < cols; col++)
                {
                    var currentNum = input[col];
                    matrix[row, col] = currentNum;
                }
            }

            for (int col = 0; col < cols; col++)
            {
                var sum = 0;

                for (int row = 0; row < rows; row++)
                {
                    var currentElement = matrix[row, col];
                    sum += currentElement;
                }

                Console.WriteLine(sum);
            }
        }

        private static int[] ParseFromConsole(params char[] splitSymbol)
        {
            return Console.ReadLine()
                .Split(splitSymbol, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}