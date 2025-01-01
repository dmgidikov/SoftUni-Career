using Cars.Interfaces;

namespace Cars
{
    public abstract class Car : ICar
    {
        private string _model;
        private string _color;

        protected Car(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Model { get; set; }

        public string Color { get; set; }

        public string Start()
        {
            throw new NotImplementedException();
        }

        public string Stop()
        {
            throw new NotImplementedException();
        }
    }
}
