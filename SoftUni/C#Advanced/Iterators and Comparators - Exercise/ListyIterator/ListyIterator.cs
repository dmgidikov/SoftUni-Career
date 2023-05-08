using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> data;
        private int index = 0;

        public ListyIterator()
        {
            this.data = new List<T>();
        }

        public ListyIterator(T item) 
        {
            this.data = new List<T>();
        }

        public List<T> Data 
        {
            get => this.data;
            set=> this.data = value;    
        }

        public bool Move()
        {
            if (++index > index && ++index < data.Count)
            {
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            var lenght = this.data.Count;
            if (lenght - index >= 0)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            throw new Exception("Invalid Operation!");
        }

        public void Print(int index)
        {
            Console.WriteLine($"{data[index]}");
        }
    }
}
