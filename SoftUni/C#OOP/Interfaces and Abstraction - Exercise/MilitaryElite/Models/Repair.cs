using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Contracts;

namespace MilitaryElite.Models
{
    public class Repair : IRepair
    {
        public Repair(string partName, int workedHours) 
        {
            this.PartName = partName;
            this.WorkedHours = workedHours;
        }

        public string PartName { get; private set; }

        public int WorkedHours { get; private set; }
    }
}
