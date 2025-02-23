namespace CyberSecurityDS.Models
{
    using Contracts;
    using Utilities.Messages;

    public abstract class DefensiveSoftware : IDefensiveSoftware
    {
        private string _name;
        private int _effectiveness;
        private readonly ICollection<string> _assignedAttacks;

        protected DefensiveSoftware(string name, int effectiveness)
        {
            Name = name;
            Effectiveness = effectiveness;
            _assignedAttacks = new List<string>();
        }

        public string Name
        {
            get => _name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.SoftwareNameRequired);
                }

                _name = value;
            }
        }

        public int Effectiveness
        {
            get => _effectiveness;
            private set
            {
                _effectiveness = value switch
                {
                    < 0 => throw new ArgumentException(ExceptionMessages.EffectivenessNegative),
                    0 => 1,
                    > 10 => 10,
                    _ => value
                };
            }
        }

        public IReadOnlyCollection<string>? AssignedAttacks => _assignedAttacks as IReadOnlyCollection<string>;

        public void AssignAttack(string attackName) => _assignedAttacks.Add(attackName);

        public override string ToString()
        {
            var result = string.Empty;

            result = _assignedAttacks.Any() ?
                $"Defensive Software: {Name}, Effectiveness: {Effectiveness}, Assigned Attacks: {string.Join(", ", _assignedAttacks)}" :
                $"Defensive Software: {Name}, Effectiveness: {Effectiveness}, Assigned Attacks: [None]";

            return result;
        }
    }
}