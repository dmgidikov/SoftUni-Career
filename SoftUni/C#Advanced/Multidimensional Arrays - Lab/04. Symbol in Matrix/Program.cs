namespace _04._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            var rows = size;
            var cols = size;

            var matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < cols; col++)
                {
                    char currentElement = input[col];
                    matrix[row, col] = currentElement;
                }
            }

            var symbol = char.Parse(Console.ReadLine());
            var containsSymbol = false;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    var currentElement = matrix[row, col];

                    if (symbol == currentElement)
                    {
                        containsSymbol = true;
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            if (containsSymbol == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}