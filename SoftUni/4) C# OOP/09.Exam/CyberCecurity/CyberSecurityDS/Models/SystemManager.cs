namespace CyberSecurityDS.Models
{
    using Contracts;
    using Repositories;
    using Repositories.Contracts;

    public class SystemManager : ISystemManager
    {
        private readonly IRepository<ICyberAttack> _cyberAttacks;
        private readonly IRepository<IDefensiveSoftware> _defensiveSoftwares;

        public SystemManager()
        {
            _cyberAttacks = new CyberAttackRepository();
            _defensiveSoftwares = new DefensiveSoftwareRepository();
        }

        public IRepository<ICyberAttack> CyberAttacks => _cyberAttacks;

        public IRepository<IDefensiveSoftware> DefensiveSoftwares => _defensiveSoftwares;
    }
}