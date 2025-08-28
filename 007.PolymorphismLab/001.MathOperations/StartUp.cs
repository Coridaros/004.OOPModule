//Polymorphism - lab, Task 001
//27.08.2025, 15:31

namespace Operations;

public class StartUp
{
    static void Main()
    {
        MathOperations mo = new MathOperations();

        Console.WriteLine(mo.Add(2, 3));
        Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
        Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));
    }
}