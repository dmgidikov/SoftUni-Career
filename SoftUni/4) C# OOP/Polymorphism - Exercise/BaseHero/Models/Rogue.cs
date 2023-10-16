using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseHero.Models
{
    public class Rogue : BaseHero
    {
        public Rogue(string name) 
            : base(name)
        {

        }

        public override int Power => 80;

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}
