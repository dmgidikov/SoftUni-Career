namespace _01._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            var matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                var cols = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    var currentElement = cols[col];
                    matrix[row, col] = currentElement;
                }
            }

            var primarySum = 0;
            var secondarySum = 0;

            for (int row = 0; row < size; row++)
            {
                var num = matrix[row, row];
                primarySum += num;
            }

            for (int row = 0; row < size; row++)
            {
               var num = matrix[size - row - 1, row];
                secondarySum += num;
            }

            Console.WriteLine(Math.Abs(primarySum - secondarySum));
        }
    }
}