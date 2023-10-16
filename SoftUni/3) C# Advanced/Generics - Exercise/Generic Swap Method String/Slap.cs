using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Swap_Method_String
{
    public class Slap<T>
    {
        public Slap(List<T> data) 
        {
            this.Data = data;
        }

        public List<T> Data { get; set; }

        public void AddElement (List<T> data, T element) 
        {
            data.Add(element);
        }      

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var item in this.Data)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            return sb.ToString().TrimEnd();
         }

        public void Swap(List<T> data, int Tfirst, int Tsecond)
        {
            var first = data[Tfirst];
            var second = data[Tsecond];

            data[Tfirst] = second;
            data[Tsecond] = first;
        }
    }
}
