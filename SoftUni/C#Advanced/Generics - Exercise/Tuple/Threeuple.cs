using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    public class Threeuple<T, N, M>
    {
        private T first;
        private N second;
        private M third;

        public Threeuple(T first, N second, M third)
        {
            this.First = first;
            this.Second = second;
            this.Third = third;
        }

        public T First
        {
            get => this.first;
            set => this.first = value;
        }

        public N Second
        {
            get => this.second;
            set => this.second = value;
        }

        public M Third
        {
            get => this.third;
            set => this.third = value;
        }

        public override string ToString()
        {
            return $"{first} -> {second} -> {third}";
        }
    }
}
