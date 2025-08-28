using Vehicle.IO.Interfaces;

namespace Vehicle.IO;

public class Reader : IReader
{
    public string ReadLine()
    {
        return Console.ReadLine();
    }
}
