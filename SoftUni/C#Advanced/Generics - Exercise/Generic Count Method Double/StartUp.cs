namespace Generic_Count_Method_Double
{
    public class StartUp
    {
        static void Main()
        {
            var rotations = int.Parse(Console.ReadLine());  

            var elements = new List<double>();

            for (int i = 0; i < rotations; i++)
            {
                var element = double.Parse(Console.ReadLine());

                elements.Add(element);
            }

            var boxOfDoubles = new Box<double>(elements);

            var comparer = double.Parse(Console.ReadLine());

            var counter = boxOfDoubles.CountOfBiggerElements(elements, comparer);

            Console.WriteLine(counter);
        }
    }
}