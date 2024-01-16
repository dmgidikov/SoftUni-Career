namespace EvenNumber
{
    public class StartUp
    {
        public static void Main()
        {

            while (true)
            {
                var rndmNum = int.Parse(Console.ReadLine());

                if (rndmNum % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(rndmNum)}");
                    break;
                }
            }
        }
    }
}
