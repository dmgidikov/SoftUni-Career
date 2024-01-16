namespace MultiplicationTable2._0
{
    public class StartUp
    {
        public static void Main()
        {
            var rnmNum = int.Parse(Console.ReadLine());
            var startingPoint = int.Parse(Console.ReadLine());

            if (startingPoint > 10)
            {
                Console.WriteLine($"{rnmNum} X {startingPoint} = {rnmNum * startingPoint}");
            }
            else
            {
                for (int i = startingPoint; i <= 10; i++)
                {
                    Console.WriteLine($"{rnmNum} X {i} = {rnmNum * i}");
                }
            }
        }
    }
}
