namespace Shapes
{
    public class Rectangle : Shape
    {
        private double _height;
        private double _width;

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height { get; private set; }

        public double Width { get; private set; }

        public override double CalculateArea()
        {
            return this.Height * this.Width;
        }

        public override double CalculatePerimeter()
        {
            return (this.Height + this.Width) * 2;
        }

        public override string Draw()
        {
            return base.Draw() + nameof(Rectangle);
        }
    }
}
