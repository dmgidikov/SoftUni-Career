namespace CyberSecurityDS.Core
{
    using Models;
    using Contracts;
    using System.Text;
    using Models.Contracts;
    using Utilities.Messages;

    public class Controller : IController
    {
        private readonly ISystemManager _systemManager;

        public Controller()
        {
            _systemManager = new SystemManager();
        }

        public string AddCyberAttack(string attackType, string attackName, int severityLevel, string extraParam)
        {
            var message = string.Empty;

            if (_systemManager.CyberAttacks.Exists(attackName))
            {
                message = string.Format(OutputMessages.EntryAlreadyExists, attackName);
                return message;
            }

            if (!(attackType == nameof(PhishingAttack) || attackType == nameof(MalwareAttack)))
            {
                message = string.Format(OutputMessages.TypeInvalid, attackType);
                return message;
            }

            ICyberAttack? cyberAttack = attackType switch
            {
                nameof(PhishingAttack) => new PhishingAttack(attackName, severityLevel, extraParam),
                nameof(MalwareAttack) => new MalwareAttack(attackName, severityLevel, extraParam),
                _ => null
            };

            _systemManager.CyberAttacks.AddNew(cyberAttack);
            message = string.Format(OutputMessages.EntryAddedSuccessfully, attackType, attackName);
            return message;
        }

        public string AddDefensiveSoftware(string softwareType, string softwareName, int effectiveness)
        {
            var message = string.Empty;

            if (_systemManager.DefensiveSoftwares.Exists(softwareName))
            {
                message = string.Format(OutputMessages.EntryAlreadyExists, softwareName);
                return message;
            }

            if (!(softwareType == nameof(Firewall) || softwareType == nameof(Antivirus)))
            {
                message = string.Format(OutputMessages.TypeInvalid, softwareType);
                return message;
            }

            IDefensiveSoftware? defensiveSoftware = softwareType switch
            {
                nameof(Firewall) => new Firewall(softwareName, effectiveness),
                nameof(Antivirus) => new Antivirus(softwareName, effectiveness),
                _ => null
            };

            _systemManager.DefensiveSoftwares.AddNew(defensiveSoftware);
            message = string.Format(OutputMessages.EntryAddedSuccessfully, softwareType, softwareName);
            return message;
        }

        public string AssignDefense(string cyberAttackName, string defensiveSoftwareName)
        {
            var message = string.Empty;

            if (!_systemManager.CyberAttacks.Exists(cyberAttackName))
            {
                message = string.Format(OutputMessages.EntryNotFound, cyberAttackName);
                return message;
            }

            if (!_systemManager.DefensiveSoftwares.Exists(defensiveSoftwareName))
            {
                message = string.Format(OutputMessages.EntryNotFound, defensiveSoftwareName);
                return message;
            }

            var cyberAttack = _systemManager.CyberAttacks.GetByName(cyberAttackName);
            var defensiveSoftware = _systemManager.DefensiveSoftwares.GetByName(defensiveSoftwareName);

            if (defensiveSoftware.AssignedAttacks.Contains(cyberAttack.AttackName))
            {
                message = string.Format(OutputMessages.AttackAlreadyAssigned, cyberAttackName, defensiveSoftwareName);
                return message;
            }

            defensiveSoftware.AssignAttack(cyberAttackName);
            message = string.Format(OutputMessages.AttackAssignedSuccessfully, cyberAttackName, defensiveSoftwareName);
            return message;
        }

        public string MitigateAttack(string cyberAttackName)
        {
            var message = string.Empty;

            if (!_systemManager.CyberAttacks.Exists(cyberAttackName))
            {
                message = string.Format(OutputMessages.EntryNotFound, cyberAttackName);
                return message;
            }

            var cyberAttack = _systemManager.CyberAttacks.GetByName(cyberAttackName);

            if (cyberAttack.Status)
            {
                message = string.Format(OutputMessages.AttackAlreadyMitigated, cyberAttackName);
                return message;
            }

            if (!_systemManager.DefensiveSoftwares.Models.Any(x => x.AssignedAttacks.Contains(cyberAttackName)))
            {
                message = string.Format(OutputMessages.AttackNotAssignedYet, cyberAttackName);
                return message;
            }

            var defensiveSoftware = _systemManager.DefensiveSoftwares.Models.First(x => x.AssignedAttacks.Contains(cyberAttackName));

            if (defensiveSoftware.Name == nameof(Firewall))
            {
                if (cyberAttackName != nameof(MalwareAttack))
                {
                    message = string.Format(OutputMessages.CannotMitigateDueToCompatibility, defensiveSoftware.Name, cyberAttackName);
                    return message;
                }
            }

            if (defensiveSoftware.Name == nameof(Antivirus))
            {
                if (cyberAttackName != nameof(PhishingAttack))
                {
                    message = string.Format(OutputMessages.CannotMitigateDueToCompatibility, defensiveSoftware.Name, cyberAttackName);
                    return message;
                }
            }

            if (defensiveSoftware.Effectiveness >= cyberAttack.SeverityLevel)
            {
                cyberAttack.MarkAsMitigated();
                message = string.Format(OutputMessages.AttackMitigatedSuccessfully, cyberAttackName);
                return message;
            }

            message = string.Format(OutputMessages.SoftwareNotEffectiveEnough, cyberAttackName, defensiveSoftware.Name);
            return message;
        }

        public string GenerateReport()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Security:");
            foreach (var defensiveSoftware in _systemManager.DefensiveSoftwares.Models.OrderBy(x => x.Name))
            {
                sb.AppendLine(defensiveSoftware.ToString());
            }

            sb.AppendLine("Threads:");
            sb.AppendLine("Mitigated:");

            foreach (var cyberAttack in _systemManager.CyberAttacks.Models.Where(x => x.Status).OrderBy(x => x.AttackName))
            {
                sb.AppendLine($"Attack: {cyberAttack}");
            }

            sb.AppendLine("Pending:");

            foreach (var cyberAttack in _systemManager.CyberAttacks.Models.Where(x => x.Status == false).OrderBy(x => x.AttackName))
            {
                sb.AppendLine($"Attack: {cyberAttack}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
