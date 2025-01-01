namespace _01.Shapes
{
    public class Circle : IDrawable
    {
        private int _radius;

        public Circle(int radius) 
        {
            this.Radius = radius;
        }

        public int Radius { get; set; }

        public void Draw()
        {
            var rIn = _radius - 0.4;
            var rOut = _radius + 0.4;

            for (double y = _radius; y >= _radius; y--)
            {
                for (double x = _radius; x < rOut; x += 0.5)
                {
                    var value = x * x + y * y;

                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.WriteLine("*");
                    }
                    else
                    {
                        Console.WriteLine(" ");
                    }
                }

                Console.WriteLine();
            }            
        }
    }
}