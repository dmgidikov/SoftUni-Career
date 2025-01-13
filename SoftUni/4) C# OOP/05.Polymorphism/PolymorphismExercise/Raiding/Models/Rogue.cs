namespace Raiding.Models
{
    using Contracts;

    public class Rogue : BaseHero, IRogue
    {
        private const int ROGUE_DEFAULT_ATTACK = 80;

        public Rogue(string name)
            : base(name)
        {
            this.Power = ROGUE_DEFAULT_ATTACK;
        }

        public override string CastAbility()
        {
            return $"{nameof(Rogue)} - {this.Name} healed for {this.Power} damage";
        }
    }
}