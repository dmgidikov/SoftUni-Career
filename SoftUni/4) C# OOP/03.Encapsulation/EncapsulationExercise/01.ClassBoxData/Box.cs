namespace ClassBoxData
{
    public class Box
    {
        private const int SIDE_MIN_VALUE = 0;
        private const string INVALID_SIDE_MESSAGE = "{0} cannot be zero or negative";

        private double _length;
        private double _width;
        private double _height;

        public Box(double length, double width, double height)
        {
            _length = length;
            _width = width;
            _height = height;
        }

        public double Length
        {
            get => _length;
            private set
            {
                ValidateSide(value, nameof(this.Length));
                _length = value;
            }
        }

        public double Width
        {
            get => _width;
            private set 
            {
                ValidateSide(value, nameof(this.Width));
                _width = value;
            }
        }

        public double Height
        {
            get => _height;
            private set
            {
                ValidateSide(value, nameof(this.Height));
                _width = value;
            }
        }

        public double GetVolume()
        {
            return _width * _height * _length;
        }

        public double GetLateralSurfaceArea()
        {
            var result = 2 * _length * _height + 2 * _width * _height;

            return result;
        }

        public double GetSurfaceArea()
        {
            var result = 2 * _length * _width + this.GetLateralSurfaceArea();
            return result;
        }

        private static void ValidateSide(double value, string sideName)
        {
            if (value <= SIDE_MIN_VALUE)
            {
                throw new ArgumentException(string.Format
                    (INVALID_SIDE_MESSAGE, sideName));
            }
        }
    }
}