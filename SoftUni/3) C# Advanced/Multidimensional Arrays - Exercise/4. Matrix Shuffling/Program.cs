using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _4.Matrix_Shuffling
{
    internal class Program
    {
        static void Main()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var rows = dimensions[0];
            var cols = dimensions[1];

            var matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] currentCol = ReadAndSplit();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentCol[col];
                }
            }

            while (true)
            {
                var input = ReadAndSplit();

                if (input[0] == "END")
                {
                    break;
                }

                if (input[0] != "swap" || input.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    var firstRow = int.Parse(input[1]);
                    var firstCol = int.Parse(input[2]);

                    var changeRow = int.Parse(input[3]);
                    var changeCol = int.Parse(input[4]); 

                    if (firstRow <= rows && changeRow <= rows
                        && firstCol <= cols && changeCol <= cols)
                    {
                        var firstElement = matrix[firstRow, firstCol];
                        var secondElement = matrix[changeRow, changeCol];

                        matrix[firstRow, firstCol] = secondElement;
                        matrix[changeRow, changeCol] = firstElement;

                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < cols; col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
            }
        }

        private static string[] ReadAndSplit()
        {
            return Console.ReadLine().Split();
        }
    }
}
