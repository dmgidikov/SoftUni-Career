using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Kitten : Cat
    {
        private const string KITTEN_GENDER = "female";
        public Kitten(string name, int age) 
            : base(name, age, KITTEN_GENDER)
        {
            this.sound = "Meow";
        }
    }
}
