namespace CyberSecurityDS.Repositories
{
    using Contracts;
    using Models.Contracts;

    public class DefensiveSoftwareRepository : IRepository<IDefensiveSoftware>
    {
        private readonly ICollection<IDefensiveSoftware> _models;

        public DefensiveSoftwareRepository()
        {
            _models = new List<IDefensiveSoftware>();
        }

        public IReadOnlyCollection<IDefensiveSoftware>? Models => _models as IReadOnlyCollection<IDefensiveSoftware>;

        public void AddNew(IDefensiveSoftware model) => _models.Add(model);

        public IDefensiveSoftware? GetByName(string name)
        {
            IDefensiveSoftware defensiveSoftware;

            if (_models.Any(x => x.Name == name))
            {
                defensiveSoftware = _models.First(x => x.Name == name);
                return defensiveSoftware;
            }

            return null;
        }

        public bool Exists(string name) => _models.Any(x => x.Name == name);
    }
}