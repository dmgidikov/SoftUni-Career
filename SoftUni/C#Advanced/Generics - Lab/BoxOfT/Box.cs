using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> data;

        public Box()
        {
            this.data = new Stack<T>();
        }

        public void Add(T element)
        {
            this.data.Push(element);
        }

        public T Remove()
        {
            return this.data.Pop();
        }

        public int GetCount()
        {
            return this.data.Count;
        }
    }
}
