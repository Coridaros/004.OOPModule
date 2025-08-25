//Encapsulation - exercise, Task 004
//18.07.2025, 23:31

using PizzaCalories.Models;

namespace PizzaCalories;

public class StartUp
{
    static void Main()
    {
        //Dough d = new("test", "Chewy", 300);

        //Console.WriteLine($"{d.Calories:F2}");

        Topping t = new("Meat", 110);

        Console.WriteLine(t.ToppingCalories);
    }
}