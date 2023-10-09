namespace _05._Snake_Moves
{
    public class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var r = nums[0];
            var c = nums[1];
            var matrix = new int[r, c];
            var snake = Console.ReadLine();
            var counter = 0;
            var myQue = new Queue<int>();

            var capacity = r * c;

            for (var i = 0; i < snake.Length; i++)
            {
                myQue.Enqueue(snake[i]);
                counter++;

                if (counter == capacity)
                {
                    break;
                }
                if (i == snake.Length - 1)
                {
                    i = -1;
                }
            }

            for (var j = 0; j < r; j++)
            {
                if (j % 2 == 0)
                {
                    for (var i = 0; i < c; i++)
                    {
                        matrix[j, i] = myQue.Dequeue();
                    }
                }
                else if (j % 2 != 0)
                {
                    for (var k = c - 1; k > -1; k--)
                    {
                        matrix[j, k] = myQue.Dequeue();
                    }
                }

            }

            for (var row = 0; row < matrix.GetLength(0); row++)
            {
                for (var col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0}", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}