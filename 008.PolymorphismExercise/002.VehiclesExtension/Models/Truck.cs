namespace Vehicles.Models;

public class Truck : Vehicle
{
    private const double IncreasedFuelConsumption = 1.6;

    public override double FuelConsumption => base.FuelConsumption + IncreasedFuelConsumption;

    public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    public override bool Refuel(double amount)
    {
        return base.Refuel(amount * 0.95);
    }
}
