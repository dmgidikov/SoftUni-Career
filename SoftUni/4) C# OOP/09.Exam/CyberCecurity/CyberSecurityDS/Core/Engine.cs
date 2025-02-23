namespace CyberSecurityDS.Core
{
    using IO;
    using Contracts;
    using IO.Contracts;

    public class Engine : IEngine
    {
        private IReader _reader;
        private IWriter _writer;
        private IController _controller;

        public Engine()
        {
            _reader = new Reader();
            _writer = new Writer();
            _controller = new Controller();
        }
        public void Run()
        {
            while (true)
            {
                string[] input = _reader.ReadLine().Split();
                if (input[0] == "Exit")
                {
                    Environment.Exit(0);
                }
                try
                {
                    string result = string.Empty;

                    if (input[0] == "AddCyberAttack")
                    {
                        string attackType = input[1];
                        string attackName = input[2];
                        int severityLevel = int.Parse(input[3]);
                        string extraParam = input[4];

                        result = _controller.AddCyberAttack(attackType, attackName, severityLevel, extraParam);
                    }
                    else if (input[0] == "AddDefensiveSoftware")
                    {
                        string softwareType = input[1];
                        string softwareName = input[2];
                        int effectiveness = int.Parse(input[3]);

                        result = _controller.AddDefensiveSoftware(softwareType, softwareName, effectiveness);
                    }
                    else if (input[0] == "AssignDefense")
                    {
                        string cyberAttackName = input[1];
                        string defensiveSoftwareName = input[2];

                        result = _controller.AssignDefense(cyberAttackName, defensiveSoftwareName);
                    }
                    else if (input[0] == "MitigateAttack")
                    {
                        string cyberAttackName = input[1];

                        result = _controller.MitigateAttack(cyberAttackName);
                    }
                    else if (input[0] == "GenerateReport")
                    {
                        result = _controller.GenerateReport();
                    }
                    _writer.WriteLine(result);
                    _writer.WriteText(result);
                }
                catch (Exception ex)
                {
                    _writer.WriteLine(ex.Message);
                    _writer.WriteText(ex.Message);
                }
            }
        }

    }
}