using CommandPattern.Core.Contracts;
using System.Reflection;

namespace CommandPattern.Core;

public class CommandInterpreter : ICommandInterpreter
{
    public string Read(string args)
    {
        string[] arguments = args.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        string commandName = arguments[0];
        string[] commmandArgs = arguments.Skip(1).ToArray();

        Type commandType = Assembly.GetEntryAssembly().GetTypes()
            .FirstOrDefault(t => t.Name.Equals($"{commandName}Command"));

        ICommand commandInstance = Activator.CreateInstance(commandType) as ICommand;

        string result = commandInstance.Execute(commmandArgs);

        return result;
    }
}
