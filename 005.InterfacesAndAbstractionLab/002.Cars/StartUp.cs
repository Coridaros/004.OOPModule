//Interfaces and abstraction - lab, Task 002
//16.08.2025, 16:27

namespace Cars;

public class StartUp
{
    static void Main()
    {
        ICar seat = new Seat("Leon", "Grey");
        ICar tesla = new Tesla("Model 3", "Red", 2);

        Console.WriteLine(seat.ToString());
        Console.WriteLine(tesla.ToString());
    }
}