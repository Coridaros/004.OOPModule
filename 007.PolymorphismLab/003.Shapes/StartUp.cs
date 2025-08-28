//Polymorphism - lab, Task 003
//27.08.2025, 15:50

namespace Shapes;

public class StartUp
{
    static void Main()
    {
        Shape circle = new Circle(3.3);
        Shape rectangle = new Rectangle(1.2, 1.3);

        Console.WriteLine(circle.Draw());
        Console.WriteLine(circle.CalculatePerimeter());
        Console.WriteLine(circle.CalculateArea());

        Console.WriteLine(rectangle.Draw());
        Console.WriteLine(rectangle.CalculatePerimeter());
        Console.WriteLine(rectangle.CalculateArea());
    }
}