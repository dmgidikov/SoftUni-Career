namespace Raiding.Models
{
    using Contracts;

    public class Warrior : BaseHero, IWarrior
    {
        private const int WARRIOR_DEFAULT_ATTACK = 100;

        public Warrior(string name)
            : base(name)
        {
            this.Power = WARRIOR_DEFAULT_ATTACK;
        }

        public override string CastAbility()
        {
            return $"{nameof(Warrior)} - {this.Name} healed for {this.Power} damage";
        }
    }
}