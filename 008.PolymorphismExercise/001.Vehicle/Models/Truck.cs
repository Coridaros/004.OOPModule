namespace Vehicle.Models;

public class Truck : Vehicle
{
    private const double IncreasedFuelConsumption = 1.6;

    public override double FuelConsumption => base.FuelConsumption + IncreasedFuelConsumption;

    public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
    {
    }

    public override void Refuel(double litters)
    {
        base.Refuel(litters * 0.95);
    }
}
