using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Robot : Invaders
    {
        public Robot(string name, string id) 
            : base(name)
        {
            this.Id = id;
        }

        public string Id { get; private set; }

    }
}
