//Reflection and Attributes - exercise, Task 001
//07.09.2025, 18:40

using CommandPattern.Core;
using CommandPattern.Core.Contracts;

namespace CommandPattern;

public class StartUp
{
    static void Main()
    {
        ICommandInterpreter command = new CommandInterpreter();
        IEngine engine = new Engine(command);
        engine.Run();
    }
}