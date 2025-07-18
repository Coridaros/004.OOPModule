public class Box
{
    private double length;
    private double width;
    private double height;

    public double Length
    {
        get { return length; }
        private set 
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
            }
            length = value;
        }
    }

    public double Width
    {
        get { return width; }
        private set 
        {
            if(value <= 0)
            {
                throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
            }
            width = value; 
        }
    }

    public double Height
    {
        get { return height; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
            }
            height = value;
        }
    }

    public Box(double length, double width, double heigth)
    {
        Length = length;
        Width = width;
        Height = heigth;
    }

    public double SurfaceArea()
    {
        return 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;
    }

    public double LateralSurfaceArea()
    {
        return 2 * Length * Height + 2 * Width * Height;
    }

    public double Volume()
    {
        return Length * Width * Height;
    }
}