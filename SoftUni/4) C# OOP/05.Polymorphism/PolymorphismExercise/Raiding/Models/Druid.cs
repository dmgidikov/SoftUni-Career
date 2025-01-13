namespace Raiding.Models
{
    using Contracts;

    public class Druid : BaseHero, IDruid
    {
        private const int DRUID_DEFAULT_ATTACK = 80;

        public Druid(string name) 
            : base(name)
        {
            this.Power = DRUID_DEFAULT_ATTACK; 
        }

        public override string CastAbility()
        {
            return $"{nameof(Druid)} - {this.Name} healed for {this.Power}";
        }
    }
}