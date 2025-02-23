namespace CyberSecurityDS.Models.Contracts
{
    using Repositories.Contracts;

    public interface ISystemManager
    {
        IRepository<ICyberAttack> CyberAttacks { get; }
        IRepository<IDefensiveSoftware> DefensiveSoftwares { get; }
    }
}