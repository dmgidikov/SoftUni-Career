using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, int age, string type) 
            : base(name, age, type)
        {
            this.sound = "Meow meow";
        }
    }
}
