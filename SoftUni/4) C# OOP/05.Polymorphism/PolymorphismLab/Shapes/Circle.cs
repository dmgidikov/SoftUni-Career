namespace Shapes
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; private set; }

        public override double CalculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(this.Radius, 2), 2);
        }

        public override double CalculatePerimeter()
        {
            return Math.Round(2 * Math.PI * this.Radius, 2);
        }

        public override string Draw()
        {
            return base.Draw() + nameof(Circle);
        }
    }
}