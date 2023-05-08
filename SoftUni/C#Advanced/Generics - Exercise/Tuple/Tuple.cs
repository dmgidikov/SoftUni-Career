
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    public class Tuple<T, N>
    {
        private T item;
        private N value;

        public Tuple(T item, N value)
        {
            this.Item = item;
            this.Value = value;
        }

        public T Item 
        {
            get => this.item;
            set => this.item = value;
        }

        public N Value
        {
            get => this.value;
            set => this.value = value;
        }

        public override string ToString()
        {
            return $"{item} -> {value}";
        }
    }
}
