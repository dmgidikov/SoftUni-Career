namespace Generic_Count_Method_String
{
    public class StartUp
    {
        static void Main()
        {
            var rotations = int.Parse(Console.ReadLine());

            var box = new List<string>();

            for (int i = 0; i < rotations; i++)
            {
                var input = Console.ReadLine();
                box.Add(input);
            }

            var listOfItems = new Box<string>(box);

            var item = Console.ReadLine();

            var counter = listOfItems.GetCountOfBiggerElements(box, item);

            Console.WriteLine(counter);
        }
    }
}