namespace CyberSecurityDS.Models
{
    using Contracts;
    using Utilities.Messages;

    public abstract class CyberAttack : ICyberAttack
    {
        private string _attackName;
        private int _severityLevel;

        protected CyberAttack(string attackName, int severityLevel)
        {
            AttackName = attackName;
            SeverityLevel = severityLevel;
        }

        public string AttackName
        {
            get => _attackName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.CyberAttackNameRequired);
                }

                _attackName = value;
            }
        }

        public int SeverityLevel
        {
            get => _severityLevel;
            private set
            {
                _severityLevel = value switch
                {
                    < 0 => throw new ArgumentException(ExceptionMessages.SeverityLevelNegative),
                    0 => 1,
                    > 10 => 10,
                    _ => value
                };
            }
        }

        public bool Status { get; private set; }

        public void MarkAsMitigated()
        {
            Status = true;
        }
    }
}