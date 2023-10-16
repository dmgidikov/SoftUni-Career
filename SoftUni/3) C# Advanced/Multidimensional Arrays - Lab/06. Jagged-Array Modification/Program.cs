namespace _06._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());

            var jaggedArr = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                jaggedArr[row] = currentRow;
            }

            while (true)
            {
                var input = Console.ReadLine().Split();

                var command = input[0];

                if (command == "END")
                {
                    break;
                }
                else
                {
                    var row = int.Parse(input[1]);
                    var col = int.Parse(input[2]);
                    var value = int.Parse(input[3]);

                    var matrixRows = jaggedArr.Length;

                    if (row >= 0 && row < matrixRows)
                    {
                        var colLenght = jaggedArr[row].Length;

                        if (col >= 0 && col < colLenght)
                        {
                            if (command == "Add")
                            {
                                jaggedArr[row][col] += value;
                            }
                            else if (command == "Subtract")
                            {
                                jaggedArr[row][col] -= value;
                            }
                        }
                        else
                        {
                            PrintInvalidCoordinates();
                        }
                    }
                    else
                    {
                        PrintInvalidCoordinates();
                    }
                }
            }

            foreach (var currentRow in jaggedArr)
            {
                Console.WriteLine(string.Join(" ", currentRow));
            }
        }

        private static void PrintInvalidCoordinates()
        {
            Console.WriteLine("Invalid coordinates");
        }
    }
}