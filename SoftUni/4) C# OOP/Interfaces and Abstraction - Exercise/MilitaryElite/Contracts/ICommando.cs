using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Models;

namespace MilitaryElite.Contracts
{
    public interface ICommando : ISpecialisedSoldier
    {
       IReadOnlyCollection<IMission> Missions { get; }

        void AddMission(IMission mission);
    }
}
