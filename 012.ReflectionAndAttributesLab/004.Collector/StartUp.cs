//Reflection and attributes - lab, Task 004
//06.09.2025, 00:17

namespace Stealer;

public class StartUp
{
    static void Main()
    {
        Spy spy = new Spy();

        string result = spy.CollectGettersAndSetters("Stealer.Hacker");

        Console.WriteLine(result);
    }
}