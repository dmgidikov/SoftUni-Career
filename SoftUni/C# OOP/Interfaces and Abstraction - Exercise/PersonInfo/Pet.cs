using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfo
{
    public class Pet : IBirthable
    {
        public string Name { get; private set; }

        public string Birthdate { get; private set; }   


    }
}
