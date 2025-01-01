namespace _7.MilitaryElite.Core
{
    using Models;
    using Exceptions;
    using IO.Contracts;
    using Core.Contracts;
    using _7.MilitaryElite.Contracts;

    public class Engine : IEngine
    {
        private IReader _reader;
        private IWriter _writer;

        private ICollection<ISoldier> _soldiers;

        private Engine()
        {
            _soldiers = new List<ISoldier>();
        }

        public Engine(IReader reader, IWriter writer)
            : base()
        {
            _reader = reader;
            _writer = writer;
        }

        public void Run()
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                var args = input.Split();

                var solderType = args[0];
                var id = int.Parse(args[1]);
                var firstName = args[2];
                var lastName = args[3];

                ISoldier soldier = null;

                if (solderType == "Private")
                {
                    soldier = AddPrivate(args, id, firstName, lastName);
                }
                else if (solderType == "LieutenantGeneral")
                {
                    soldier = AddGeneral(args, id, firstName, lastName);
                }
                else if (solderType == "Engineer")
                {
                    var salary = decimal.Parse(args[4]);
                    var corps = args[5];

                    try
                    {
                        soldier = AddEngineer(args, id, firstName, lastName, salary, corps);
                    }
                    catch (InvalidCorpsException ice)
                    {
                        continue;
                    }

                }
                else if (solderType == "Commando")
                {
                    var salary = decimal.Parse(args[4]);
                    var corps = args[5];

                    try
                    {
                        soldier = AddCommando(args, id, firstName, lastName, salary, corps);
                    }

                    catch (InvalidCorpsException ice)
                    {
                        continue;
                    }
                }
                else if (solderType == "Spy")
                {
                    int codeNumber = int.Parse(args[4]);

                    soldier = new Spy(id, firstName, lastName, codeNumber);
                }

                if (soldier != null)
                {
                    _soldiers.Add(soldier);
                }
            }

            foreach (var soldier in _soldiers)
            {
                _writer.WriteLine(soldier.ToString());
            }
        }

        private static ISoldier AddCommando(string[] args, int id, string firstName, string lastName, decimal salary, string corps)
        {
            ISoldier soldier;
            ICommando commando =
                                    new Commando(id, firstName, lastName, salary, corps);

            var missionArgs = args.Skip(6).ToArray();

            for (int i = 0; i < missionArgs.Length; i += 2)
            {
                try
                {
                    var missionCodeName = missionArgs[i];
                    var missionState = missionArgs[i + 1];

                    var mission = new Mission(missionCodeName, missionState);
                    commando.AddMission(mission);

                }
                catch (InvalidMissionStateException imse)
                {
                    continue;
                }
            }

            soldier = commando;
            return soldier;
        }

        private static ISoldier AddEngineer(string[] args, int id, string firstName, string lastName, decimal salary, string corps)
        {
            ISoldier soldier;
            IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);

            var repairArgs = args.Skip(6).ToArray();

            for (int i = 0; i < repairArgs.Length; i += 2)
            {
                var partName = repairArgs[i];
                var hoursWorked = int.Parse(repairArgs[i + 1]);

                var repair = new Repair(partName, hoursWorked);
                engineer.AddRepair(repair);
            }

            soldier = engineer;
            return soldier;
        }

        private ISoldier AddGeneral(string[] args, int id, string firstName, string lastName)
        {
            ISoldier soldier;
            var salary = decimal.Parse(args[4]);

            ILieutenantGeneral general =
                new LieutenantGeneral(id, firstName, lastName, salary);

            foreach (var pid in args.Skip(5))
            {
                ISoldier privateToAdd =
                    _soldiers.First(s => s.Id == int.Parse(pid));

                general.AddPrivate(privateToAdd);
            }

            soldier = general;
            return soldier;
        }

        private static ISoldier AddPrivate(string[] args, int id, string firstName, string lastName)
        {
            ISoldier soldier;
            var salary = decimal.Parse(args[4]);
            soldier = new Private(id, firstName, lastName, salary);
            return soldier;
        }
    }
}