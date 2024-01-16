namespace TriangleOfNumbers
{
    public class StartUp
    {
        public static void Main()
        {
            var rndNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rndNum; i++)
            {
                Console.Write(i + " ");

                for (int j = 1; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
