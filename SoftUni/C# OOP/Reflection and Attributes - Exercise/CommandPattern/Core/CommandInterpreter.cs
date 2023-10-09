using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private const string COMMAND_POST_FIX = "Command";

        public string Read(string args)
        {
            var commandTokens = args.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var commandName = commandTokens[0] + COMMAND_POST_FIX;
            var commandArgs = commandTokens
                .Skip(1)
                .ToArray();

            var assembly = Assembly.GetCallingAssembly();

            var commandType = assembly
                .GetTypes()
                .FirstOrDefault(t => t.Name.ToLower() == commandName.ToLower());

            if (commandType == null)
            {
                throw new ArgumentException("Invalid command type!");
            }

            var commandInstance = Activator.CreateInstance(commandType) as ICommand;

            var result = commandInstance.Execute(commandArgs);

            return result;
        }
    }
}
