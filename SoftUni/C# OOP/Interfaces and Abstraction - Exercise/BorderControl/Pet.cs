using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Pet : Invaders
    {
        public Pet(string name, string birthday) 
            : base(name)
        {
            this.Birthday = birthday;
        }

        public string Birthday { get; private set; }
    }
}
