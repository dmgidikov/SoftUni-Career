namespace ClassBoxData
{
    public class StartUp
    {
        public static void Main()
        {
            var lenght = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());


            try
            {
                var box = new Box(lenght, width, height);
                Console.WriteLine(box);
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }
        }
    }
}