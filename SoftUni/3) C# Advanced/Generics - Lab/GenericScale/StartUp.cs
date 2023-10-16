namespace GenericScale
{
    public class StartUp
    {
        static void Main()
        {
            var scale = new EqualityScale<string>("1", "1");
            Console.WriteLine(scale.AreEqual());
        }
    }
}