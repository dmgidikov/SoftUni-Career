namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main()
        {
            var strings = ArrayCreator.Create(5, "Pesho");
            var integers = ArrayCreator.Create(5, 33);
        }
    }
}