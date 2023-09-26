using MilitaryElite.Contracts;
using MilitaryElite.Core.Contracts;
using MilitaryElite.IO.Contracts;
using MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;

        private ICollection<ISoldier> soldiers;

        private Engine()
        {
            this.soldiers = new List<ISoldier>();
        }

        public Engine(IReader reader, IWriter writer)
            :base()
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            while (true)
            {
                var command = this.reader.ReadLine().Split();

                if (command[0] == "End")
                {
                    break;
                }

                var soldierType = command[0];
                var id = int.Parse(command[1]);
                var firstName = command[2];
                var lastName = command[3];


                ISoldier soldier;

                switch (soldierType)
                {
                    case "Private":
                        var salaryPrivate = decimal.Parse(command[4]); break;
                    case "LiutenantGeneral":
                        var salaryLeutenantGeneral = decimal.Parse(command[4]);
                        soldier = new LieutenantGeneral(id, firstName, lastName, salaryLeutenantGeneral);
                        break;
                }
            }
        }
    }
}
