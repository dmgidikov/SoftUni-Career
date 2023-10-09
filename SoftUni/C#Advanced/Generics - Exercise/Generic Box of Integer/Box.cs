using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Box_of_Integer
{
    public class Box<T>
    {
        private T data;

        public Box(T data) 
        {
            this.Data = data;
        }

        public T Data
        {
            get => this.data;
            set => this.data = value;
        }

        public override string ToString()
        {
            return $"{this.data.GetType()}: {this.data}";
        }
    }
}
