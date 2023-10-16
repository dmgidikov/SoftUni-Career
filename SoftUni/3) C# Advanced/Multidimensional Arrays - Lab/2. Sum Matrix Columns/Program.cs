using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main()
        {
            List<int> rowsAndCols = ParseNumbers(' ', ',');

            var rows = rowsAndCols[0];
            var cols = rowsAndCols[1];

            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var currentRow = ParseNumbers(' ');

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sumOfCurrentColumn = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumOfCurrentColumn += matrix[row, col];
                }

                Console.WriteLine(sumOfCurrentColumn);
            }
        }

        private static List<int> ParseNumbers(params char[] splitSymbols)
        => Console.ReadLine()
            .Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
    }
}