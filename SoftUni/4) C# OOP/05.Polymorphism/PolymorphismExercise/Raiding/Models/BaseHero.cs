namespace Raiding.Models
{
    using Contracts;

    public abstract class BaseHero : IBaseHero
    {
        protected BaseHero(string name) 
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public int Power { get; protected set; }

        public abstract string CastAbility();
    }
}