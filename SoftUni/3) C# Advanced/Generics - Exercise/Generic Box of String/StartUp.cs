namespace Generic_Box_of_String
{
    public class StartUp
    {
        static void Main()
        {
            var rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                var randomText = Console.ReadLine();
                var result = new Box<string>(randomText);
                Console.WriteLine(result);
            }
        }
    }
}