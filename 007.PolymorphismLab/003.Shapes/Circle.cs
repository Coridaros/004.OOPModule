namespace Shapes;

public class Circle : Shape
{
    public double Radius { get; private set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return 2 * Math.PI * Radius;
    }

    public override double CalculatePerimeter()
    {
        return Math.PI * Radius * Radius;
    }

    public override string Draw()
    {
        return base.Draw() + $"{GetType().Name}";
    }
}
