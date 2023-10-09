using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseHero.Models
{
    public class Druid : BaseHero
    {
        public Druid(string name)
            : base(name)
        {

        }

        public override int Power => 80;

        public override string CastAbility()
        {
            return base.CastAbility();
        }
    }
}
