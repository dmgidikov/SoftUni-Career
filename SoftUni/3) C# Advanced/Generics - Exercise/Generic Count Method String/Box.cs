using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Count_Method_String
{
    public class Box<T> where T : IComparable
    {
        private List<T> data;

        public Box(List<T> data) 
        {
            data = new List<T>();
        }
        public List<T> Data
        {
            get => data; 
            set => data = value;
        }

        public void AddElement(T element)
        {
            data.Add(element);
        }

        public int GetCountOfBiggerElements(List<T> list, T item)
        {
            var count = 0;

            for (int i = 0; i < list.Count; i++)
            {
                var temp = list[i];

                if (item.CompareTo(temp) < 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
