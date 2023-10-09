namespace _02._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var size = ReadFromConsole();

            var rows = int.Parse(size[0]);
            var cols = int.Parse(size[1]);

            var matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var elements = ReadFromConsole();

                for (int col = 0; col < cols; col++)
                {
                    var currentElement = elements[col];
                    matrix[row, col] = currentElement;
                }
            }

            var counter = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    var firstElement = matrix[row, col];
                    var secondElement = matrix[row, col + 1];
                    var thirdElement = matrix[row + 1, col];
                    var fourthElement = matrix[row + 1, col + 1];

                    if (firstElement.Equals(secondElement)
                        && firstElement.Equals(thirdElement)
                        && firstElement.Equals(fourthElement))
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }

        private static string[] ReadFromConsole()
        {
            return Console.ReadLine().Split();
        }
    }
}