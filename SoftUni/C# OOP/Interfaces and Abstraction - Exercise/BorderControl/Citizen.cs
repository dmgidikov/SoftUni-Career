using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Citizen : Invaders, ICitizen
    {
        public Citizen(string name, int age, string id, string birthday)
            :base(name)
        {
            this.Age = age;
            this.Id = id;
            this.Birthday = birthday;
        }      

        public int Age { get; private set; }

        public string Id { get; private set; }

        public string Birthday { get; private set; }
    }
}
