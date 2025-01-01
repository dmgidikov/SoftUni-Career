namespace _7.MilitaryElite.Contracts
{
    using Enumerations;

    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}