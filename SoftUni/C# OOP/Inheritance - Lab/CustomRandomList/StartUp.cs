namespace CustomRandomList
{
    public class StartUp
    {
        static void Main()
        {
            var list = new RandomList()
            {
                "pesho",
                "gosho",
                "ivan"
            };

            var result = list.ReturnElement();

            Console.WriteLine(result);
        }
    }
}