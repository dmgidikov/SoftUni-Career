namespace Shapes
{
    public class StartUp
    {
        public static void Main()
        {
            var rectangle = new Rectangle(2.2, 3.3);
            var circle = new Circle(5.5);

            Console.WriteLine(rectangle.Draw());
            Console.WriteLine(circle.Draw());
        }
    }
}