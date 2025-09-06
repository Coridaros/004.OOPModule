//Reflection and attributes - lab, Task 001
//06.09.2025, 22:11

namespace Stealer;

public class StartUp
{
    static void Main()
    {
        Spy spy = new Spy();

        string result = spy.StealFieldInfo("Stealer.Hacker", "username", "password");

        Console.WriteLine(result);
    }
}