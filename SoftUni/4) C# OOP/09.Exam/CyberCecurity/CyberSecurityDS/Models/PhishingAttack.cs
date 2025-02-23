namespace CyberSecurityDS.Models
{
    using Utilities.Messages;

    public class PhishingAttack : CyberAttack
    {
        private string _targetMail;

        public PhishingAttack(string attackName, int severityLevel, string targetMail)
            : base(attackName, severityLevel)
        {
            _targetMail = targetMail;
        }

        public string TargetMail
        {
            get => _targetMail;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.TargetMailRequired);
                }

                _targetMail = value;
            }
        }

        public override string ToString()
        {
            return $"Attack: {AttackName}, Severity: {SeverityLevel} (Target Mail: {TargetMail})";
        }
    }
}