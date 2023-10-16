using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return 3.14 * (this.radius * this.radius);
        }

        public override double CalculatePerimeter()
        {
            return 2 * 3.14 * this.radius;
        }

        public override string Draw()
        {
            return base.Draw();
        }
    }
}
