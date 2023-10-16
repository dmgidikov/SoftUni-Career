using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Tomcat : Cat
    {
        private const string TOMCAT_GENDER = "male";
        public Tomcat(string name, int age)
            : base(name, age, TOMCAT_GENDER)
        {
            this.sound = "MEOW";
        }
    }
}
