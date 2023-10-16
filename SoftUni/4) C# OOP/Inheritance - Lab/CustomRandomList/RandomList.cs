using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string ReturnElement()
        {
            var random = new Random();

            var index = random.Next(0, this.Count - 1);

            var element = this[index];

            this.RemoveAt(index);

            return element;
        }
    }
}
