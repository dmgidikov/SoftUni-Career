using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Box_of_String
{
    public class Box<T>
    {
        private T data;

        public Box(T value) 
        {
           this.Value = value;
        }

        public T Value
        {
            get => this.data;
            set => this.data = value;
        }

        public override string ToString()
        {
            return $"{this.data.GetType()}: {data}";
        }
    }
}
