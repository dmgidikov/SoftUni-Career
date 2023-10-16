using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _4.Symbol_in_Matrix
{
    internal class Program
    {
        static void Main()
        {
            var RowsAndCols = int.Parse(Console.ReadLine());

            var rows = RowsAndCols;
            var cols = RowsAndCols;

            var matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            var symbol = char.Parse(Console.ReadLine());
            var containsSymbol = false;
            
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    var currentElement = matrix[row, col];

                    if (symbol == currentElement)
                    {
                        containsSymbol = true;
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            if (containsSymbol == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
