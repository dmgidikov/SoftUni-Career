using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3.Maximal_Sum
{
    internal class Program
    {
        static void Main()
        {
            int[] dimensions = ParseArrayFromConsole();

            var rows = dimensions[0];
            var cols = dimensions[1];

            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var currentCol = ParseArrayFromConsole();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentCol[col];
                }
            }

            var startRow = 0;
            var startCol = 0;
            var biggestSum = 0;

            for (var row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (var col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    var currentSum = 0;

                    for (var x = row; x < row + 3; x++)
                    {
                        for (var y = col; y < col + 3; y++)
                        {
                            currentSum += matrix[x, y];
                        }
                    }

                    if (currentSum > biggestSum)
                    {
                        biggestSum = currentSum;
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            var sb = new StringBuilder();
            sb.AppendLine($"Sum = {biggestSum}");

            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int y = startCol; y < startCol + 3; y++)
                {
                    sb.Append(matrix[i, y] + " ");
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString().Trim());

        }


        static int[] ParseArrayFromConsole()
        {
            return Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
    }
}
