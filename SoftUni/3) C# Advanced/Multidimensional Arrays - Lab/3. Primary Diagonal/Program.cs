using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3.Primary_Diagonal
{
    internal class Program
    {
        static void Main()
        {
            int[] dimensions = ParseArrayFromConsole();

            var rows = dimensions[0];
            var cols = dimensions[0];

            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var currentCol = ParseArrayFromConsole();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentCol[col];
                }
            }

            var sum = 0;

            for (int i = 0; i < rows; i++)
            {
                var currentElement = matrix[i, i];
                sum += currentElement;             
            }

            Console.WriteLine(sum);
        }

        private static int[] ParseArrayFromConsole()
            =>  Console.ReadLine().Split().Select(int.Parse).ToArray();        
    }
}
