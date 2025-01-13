namespace Raiding.Models
{
    using Contracts;

    public class Paladin : BaseHero, IPaladin
    {
        private const int PALADIN_DEFAULT_ATTACK = 100;

        public Paladin(string name)
            : base(name)
        {
            this.Power = PALADIN_DEFAULT_ATTACK;
        }

        public override string CastAbility()
        {
            return $"{nameof(Paladin)} - {this.Name} healed for {this.Power}";
        }
    }
}