namespace CyberSecurityDS.Repositories
{
    using Contracts;
    using Models.Contracts;

    public class CyberAttackRepository : IRepository<ICyberAttack>
    {
        private readonly ICollection<ICyberAttack> _models;

        public CyberAttackRepository()
        {
            _models = new List<ICyberAttack>();
        }

        public IReadOnlyCollection<ICyberAttack>? Models => _models as IReadOnlyCollection<ICyberAttack>;

        public void AddNew(ICyberAttack model) => _models.Add(model);

        public ICyberAttack GetByName(string name)
        {
            ICyberAttack cyberAttack;

            if (_models.Any(x => x.AttackName == name))
            {
                cyberAttack = _models.First(x => x.AttackName == name);
                return cyberAttack;
            }

            return null;
        }

        public bool Exists(string name) => _models.Any(x => x.AttackName == name);
    }
}