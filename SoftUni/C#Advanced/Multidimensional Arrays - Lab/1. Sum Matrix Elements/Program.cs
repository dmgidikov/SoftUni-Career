using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main()
        {
            List<int> rowsAndCols = ParseFromConsole();

            var rows = rowsAndCols[0];
            var cols = rowsAndCols[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var currentRow = ParseFromConsole();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            var sum = 0;

            foreach (var element in matrix)
            {
                sum += element;
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }

        private static List<int> ParseFromConsole()
            => Console.ReadLine().Split(", ").Select(int.Parse).ToList();
    }
}
