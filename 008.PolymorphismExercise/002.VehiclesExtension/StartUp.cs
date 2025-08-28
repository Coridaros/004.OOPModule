//Polymorphism - exercise, Task 002
//25.08.2025, 21:20

using Vehicles.Core;
using Vehicles.Core.Interfaces;
using Vehicles.Factories;
using Vehicles.Factories.Interfaces;
using Vehicles.IO;
using Vehicles.IO.Interfaces;

namespace Vehicle;

public class StartUp
{
    static void Main()
    {
        IReader reader = new ConsoleReader();
        IWritter writer = new ConsoleWritter();
        IVehicleFactory vehicleFactory = new VehicleFactory();

        IEngine engine = new Engine(reader, writer, vehicleFactory);

        engine.Run();
    }
}