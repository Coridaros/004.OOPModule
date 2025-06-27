namespace NeedForSpeed;

public abstract class Vehicle
{
    private const double DefaultFuelConsumption = 1.25;

    public virtual double FuelConsumption  => DefaultFuelConsumption;
    public int HoursePower { get; set; }
    public double Fuel { get; set; }

    protected Vehicle(int hoursePower, double fuel)
    {
        this.HoursePower = hoursePower;
        this.Fuel = fuel;
    }

    public virtual void Drive(double kilometers)
    {
        Fuel -= kilometers * FuelConsumption;
    }
}