using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public abstract class Car : ICar
    {
        public Car(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }
        public string Model { get;  set; }

        public string Color { get;  set; }

        public virtual string Start()
        {
            return "Engine start";
        }

        public virtual string End()
        {
            return "Breaaak!";
        }
    }
}
