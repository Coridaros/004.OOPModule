using Vehicles.IO.Interfaces;

namespace Vehicles.IO;

public class ConsoleWritter : IWritter
{
    public void WriteLine(string msg)
    {
        Console.WriteLine(msg);
    }
}
