namespace CommandPattern.Core
{
    using Contracts;
    using System.Reflection;

    public class CommandInterpreter : ICommandInterpreter
    {
        private const string COMMAND_POSTFIX = "Command";
        public string Read(string args)
        {

            var commandTockens = args
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var commandName = commandTockens[0] + COMMAND_POSTFIX;
            var arguments = commandTockens.Skip(1).ToArray();

            var assembly = Assembly.GetCallingAssembly();

            var commandType = assembly
                .GetTypes()
                .FirstOrDefault(c => c.Name.ToLower() == commandName.ToLower());

            if (commandType == null)
            {
                throw new ArgumentException("Invalid command type!");
            }

            var commandInstance = Activator.CreateInstance(commandType) as ICommand;

            var result = commandInstance.Execute(arguments);

            return result;
        }
    }
}