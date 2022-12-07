using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _5.Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main()
        {
            int[] dimentions = ParseArrayFromConsole();

            var rows = dimentions[0];
            var cols = dimentions[1];

            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var currentArray = ParseArrayFromConsole();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentArray[col];
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
                    var fourth = matrix[row + 1, col +1];

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
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow +1, maxCol + 1]}");
            Console.WriteLine(maxSum);
        }

        private static int[] ParseArrayFromConsole()
        {
            return Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        }
    }
}
