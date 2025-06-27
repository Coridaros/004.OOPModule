//Inheritance - exercise, Task 004
//27.06.2025, 00:22

namespace NeedForSpeed;

public class StartUp
{
    static void Main()
    {
        Car test = new(150, 100);

        test.Drive(10);

        Console.WriteLine(test.Fuel);
    }
}