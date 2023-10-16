using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBoxData
{
    public class Box
    {
        private const double MIN_VALUE = 0;
        private const string EXCEPTION = "{0} cannot be zero or negative.";

        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get => this.length;
            private set
            {
                ValidateSide(value, nameof(this.Length));
                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                ValidateSide(value, nameof(this.Width));
                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                ValidateSide(value, nameof(this.Height));
                this.height = value;
            }
        }

        private void ValidateSide(double value, string sideName)
        {
            if (value <= MIN_VALUE)
            {
                throw new Exception(string.Format(EXCEPTION, sideName));
            }
        }


        public double GetVolume()
        {
            var volume = this.length * this.width * this.height;

            return volume;
        }

        public double GetSurfaceArea()
        {
            var surfaceArea = (2 * this.length * this.width) +
                (2 * this.length * this.height) +
                (2 * this.width * this.height);

            return surfaceArea;
        }

        public double GetLateralSurfaceArea()
        {
            var lateralSurfaceArea =
                (2 * this.length * this.height) +
                (2 * this.width * this.height);

            return lateralSurfaceArea;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Surface Area - {this.GetSurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {this.GetLateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {this.GetVolume():f2}");

            return sb.ToString().TrimEnd();
        }
    }
}
