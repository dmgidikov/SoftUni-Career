namespace _01._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ParseFromConsole();

            var rows = sizes[0];
            var cols = sizes[1];

            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var input = ParseFromConsole();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            var sum = 0;

            foreach (var num in matrix)
            {
                sum += num;
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }

        private static int[] ParseFromConsole()
        {       
            return Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
        }
    }
}