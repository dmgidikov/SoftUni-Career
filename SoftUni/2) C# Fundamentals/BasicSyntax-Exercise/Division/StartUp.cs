namespace Division
{
    public class StartUp
    {
        public static void Main()
        {
            var rnmdNum = int.Parse(Console.ReadLine());

            if (rnmdNum % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (rnmdNum % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (rnmdNum % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (rnmdNum % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (rnmdNum % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
