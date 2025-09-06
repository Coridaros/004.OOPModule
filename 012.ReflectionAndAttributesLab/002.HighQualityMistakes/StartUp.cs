//Reflection and attrubutes - lab, Task 002
//06.09.2025, 22:46

namespace Stealer;

public class StartUp
{
    static void Main()
    {
        Spy spy = new Spy();

        string result = spy.AnalyzeAccessModifiers("Stealer.Hacker");

        Console.WriteLine(result);
    }
}