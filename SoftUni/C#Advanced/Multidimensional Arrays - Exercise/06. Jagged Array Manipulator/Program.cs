namespace _06._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lenght = int.Parse(Console.ReadLine());

            var jaggedArr = new int[lenght][];

            for (int row = 0; row < lenght; row++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArr[row] = input;
            }

            for (int row = 0; row < lenght - 1; row++)
            {
                var currentRowLenght = jaggedArr[row].Length;
                var nextRowLenght = jaggedArr[row + 1].Length;

                if (currentRowLenght == nextRowLenght)
                {
                    for (int i = 0; i < currentRowLenght; i++)
                    {
                        jaggedArr[row][i] *= 2;
                        jaggedArr[row + 1][i] *= 2;
                    }
                }
                else
                {
                    for (int i = 0; i < currentRowLenght; i++)
                    {
                        jaggedArr[row][i] /= 2;
                    }

                    for (int i = 0; i < nextRowLenght; i++)
                    {
                        jaggedArr[row + 1][i] /= 2;
                    }
                }
            }

            while (true)
            {
                var input = Console.ReadLine().ToLower().Split();

                if (input[0] == "end")
                {
                    for (int i = 0; i < lenght; i++)
                    {
                        Console.WriteLine(string.Join(" ", jaggedArr[i]));
                    }

                    break;
                }
                else
                {
                    var row = int.Parse(input[1]);
                    var col = int.Parse(input[2]);
                    var value = int.Parse(input[3]);

                    if (row >= 0 && col >= 0)
                    {
                        if (lenght > row && jaggedArr[row].Length > col)
                        {
                            if (input[0] == "add")
                            {
                                jaggedArr[row][col] += value;
                            }
                            else if (input[0] == "subtract")
                            {
                                jaggedArr[row][col] -= value;
                            }
                        }
                    }                    
                }
            }
        }
    }
}