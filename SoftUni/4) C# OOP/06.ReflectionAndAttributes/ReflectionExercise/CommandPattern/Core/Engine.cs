namespace CommandPattern.Core
{
    using Contracts;
    using CommandPattern.Models;

    public class Engine : IEngine
    {
        private readonly ICommandInterpreter _commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter) 
        {
            _commandInterpreter = commandInterpreter;
        }

        public void Run()
        {       
            while (true)
            {
                var input = Console.ReadLine();

                try
                {
                    var result = _commandInterpreter.Read(input);

                    Console.WriteLine(result);
                }
                catch (Exception ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }
    }
}