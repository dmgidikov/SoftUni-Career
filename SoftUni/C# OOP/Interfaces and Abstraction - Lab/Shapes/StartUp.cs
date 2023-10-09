namespace Shapes
{
    public class StartUp
    {
        public static void Main()
        {
            var radius = int.Parse(Console.ReadLine());
            var cirle = new Circle(radius);

            var widht = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            var rect = new Rectangle(widht, height);

            cirle.Draw();
            rect.Draw();
        }
    }
}