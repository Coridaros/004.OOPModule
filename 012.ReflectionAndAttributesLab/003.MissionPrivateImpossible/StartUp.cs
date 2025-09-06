//Reflection and attributes - lab, Task 003
//06.09.2025, 23:52

using System;

namespace Stealer;

public class StartUp
{
    static void Main()
    {
        Spy spy = new Spy();

        string result = spy.RevealPrivateMethods("Stealer.Hacker");

        Console.WriteLine(result);
    }
}