using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Frog : Animal
    {
        public Frog(string name, int age, string type) 
            : base(name, age, type)
        {
            this.sound = "Ribbit";
        }
    }
}
