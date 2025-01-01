namespace _01.Shapes
{
    public class Rectangle : IDrawable
    {
        private int _width;
        private int _height;

        public Rectangle(int width, int height)
        {
            this.Width = width; 
            this.Height = height;
        }

        public int Width { get; set; }

        public int Height { get; set; }

        public void Draw()
        {
            DrawLine(_width, '*', '*');

            for (int i = 1; i < _height; ++i)
            {
                DrawLine(_width, '*', '*');
            }

            DrawLine(_width, '*', '*');
        }

        private void DrawLine(int width, char end, char mid)
        {
            Console.WriteLine(end);

            for (int i = 1; i < width - 1; ++i)
            {
                Console.WriteLine(mid);
            }

            Console.WriteLine(end);
        }
    }
}