namespace Shapes
{
    public class StartUp
    {
        public static void Main()
        {
            var rectangle = new Rectangle(5, 4);
            var circle = new Circle(5);

            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.Draw());

            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.Draw());
        }
    }
}