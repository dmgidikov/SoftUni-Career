using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Count_Method_Double
{
    public class Box<T> where T : IComparable
    {
        private List<T> list;

        public Box(List<T> list)
        {
           list = new List<T>();
        }

        public List<T> List
        {
            get => list; 
            set => list = value;
        }

        public int CountOfBiggerElements(List<T> list, T element)
        {
            var counter = 0;

            foreach ( var item in list)
            {
                if (element.CompareTo(item) == -1)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
