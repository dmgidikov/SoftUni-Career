using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _1.Diagonal_Difference
{
    internal class Program
    {
        static void Main()
        {
            var dimensions = int.Parse(Console.ReadLine());

            var rows = dimensions;
            var cols = dimensions;

            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var currentArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentArray[col];
                }
            }

            var primaryDiagonal = 0;
            var secondaryDiagonal = 0;

            for (int row = 0; row < rows; row++)
            {
                primaryDiagonal += matrix[row, row];
            }

            for (int col = 0; col < cols; col++)
            {
                secondaryDiagonal += matrix[col, cols - col - 1];
            }

            var result = Math.Abs(primaryDiagonal - secondaryDiagonal);
            Console.WriteLine(secondaryDiagonal);
        }
    }
}
