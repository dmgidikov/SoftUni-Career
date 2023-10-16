namespace _04._Matrix_Shuffling
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
                var colElements = ReadFromConsole();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            while (true)
            {
                var input = ReadFromConsole();

                if (input[0] == "END")
                {
                    break;
                }
                else if (input[0] == "swap" && input.Length == 5)
                {
                    var originalElementRow = int.Parse(input[1]);
                    var originalElementCol = int.Parse(input[2]);

                    var replaceElementRow = int.Parse(input[3]);
                    var replaceElementCol = int.Parse(input[4]);

                    if (originalElementCol < cols && originalElementRow < rows
                       && replaceElementRow < rows && replaceElementCol < cols)
                    {
                        var currentElement = matrix[originalElementRow, originalElementCol];
                        var newElement = matrix[replaceElementRow, replaceElementCol];

                        matrix[originalElementRow, originalElementCol] = newElement;
                        matrix[replaceElementRow, replaceElementCol] = currentElement;

                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < cols; col++)
                            {
                                var temp = matrix[row, col];
                                Console.Write(temp + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        PrintInvalidInput();
                    }
                }
                else
                {
                    PrintInvalidInput();
                }
            }

        }

        private static void PrintInvalidInput()
        {
            Console.WriteLine("Invalid input!");
        }

        static string[] ReadFromConsole()
        {
            return Console.ReadLine().Split();
        }
    }
}