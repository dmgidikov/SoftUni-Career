using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            if (this.Count == 0) return true; return false;
        }

        public void AddRange(Stack<string> values)
        {
            foreach (var item in values)
            {
                this.Push(item);
            }
        }
    }
}
