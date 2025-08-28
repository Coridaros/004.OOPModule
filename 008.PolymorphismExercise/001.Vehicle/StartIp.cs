//Polymorphism - exercise, Task 001
//22.08.2025, 01:00

using Vehicle.Core;
using Vehicle.Core.Interfaces;
using Vehicle.IO;
using Vehicle.IO.Interfaces;
using Vehicle.Models;
using Vehicle.Models.Interfaces;

namespace Vehicle;

public class StartIp
{
    static void Main()
    {
        IReader reader = new Reader();
        IWritter writter = new Writter();

        IEngine engine = new Engine(reader, writter);

        engine.Run();
    }
}
