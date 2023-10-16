using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public abstract class Invaders : IRobot, IPet
    {
        public Invaders(string name) 
        {
            this.Name = name;
        }

        public string Name { get; }

        public string Id { get; }

        public string Birthday { get; }
    }
}
