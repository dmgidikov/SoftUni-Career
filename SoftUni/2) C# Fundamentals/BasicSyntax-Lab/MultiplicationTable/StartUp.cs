namespace MultiplicationTable
{
    public class StartUp
    {
        public static void Main()
        {
            var rnmNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{rnmNum} X {i} = {rnmNum * i}");
            }
        }
    }
}
