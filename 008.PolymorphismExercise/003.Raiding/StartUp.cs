using Raiding.Core.Interfaces;
using Raiding.Factories;
using Raiding.Factories.Interfaces;
using Raiding.IO;
using Raiding.IO.Interfaces;

namespace Raiding;

public class StartUp
{
    static void Main()
    {
        IWriter writer = new ConsoleWriter();
        IReader reader = new ConsoleReader();
        IHeroFactory heroFactory = new HeroFactory();

        Engine engine = new Engine(reader, writer, heroFactory);

        engine.Run();
    }
}
