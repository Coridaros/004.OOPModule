//Interfaces and abstraction - lab, Task 001
//09.08.2025, 17:72

namespace Shapes;

public class StartUp
{
    static void Main()
    {
        var radius = int.Parse(Console.ReadLine());
        IDrawable circle = new Circle(radius);

        var width = int.Parse(Console.ReadLine());
        var height = int.Parse(Console.ReadLine());
        IDrawable rect = new Rectangle(width, height);

        circle.Draw();
        rect.Draw();

    }
}