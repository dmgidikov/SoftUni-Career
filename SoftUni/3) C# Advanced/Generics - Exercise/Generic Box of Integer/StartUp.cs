namespace Generic_Box_of_Integer
{
    public class StartUp
    {
        static void Main()
        {
            var rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                var nums = int.Parse(Console.ReadLine());

                var box = new Box<int>(nums);
                Console.WriteLine(box);
            }
        }
    }
}