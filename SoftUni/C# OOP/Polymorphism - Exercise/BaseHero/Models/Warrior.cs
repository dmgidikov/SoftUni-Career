using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseHero.Models
{
    public class Warrior : BaseHero
    {
        public Warrior(string name) 
            : base(name)
        {

        }

        public override int Power => 100;

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}
