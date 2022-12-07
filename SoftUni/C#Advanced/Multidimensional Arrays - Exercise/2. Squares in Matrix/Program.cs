using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _2.Squares_in_Matrix
{
    internal class Program
    {
        static void Main()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var rows = dimensions[0];
            var cols = dimensions[1];

            var matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var charArr = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = charArr[col];
                }
            }

            var count = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    var first = matrix[row, col];
                    var second = matrix[row, col + 1];

                    var third = matrix[row + 1, col];
                    var fourth = matrix[row + 1, col + 1];

                    if (first == second && first == third && first == fourth)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
