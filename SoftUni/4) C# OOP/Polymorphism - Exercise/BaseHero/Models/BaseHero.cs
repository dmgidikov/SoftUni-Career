using BaseHero.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseHero.Models
{
    public abstract class BaseHero : IBaseHero
    {
        public BaseHero(string name) 
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public virtual int Power { get; private set; }

        public virtual string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}
