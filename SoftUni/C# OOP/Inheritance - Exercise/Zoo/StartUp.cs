namespace Zoo
{
    public class StartUp
    {
        public static void Main()
        {
            var name = Console.ReadLine();

            var reptile = new Reptile(name);

            Console.WriteLine(reptile);
        }
    }
}