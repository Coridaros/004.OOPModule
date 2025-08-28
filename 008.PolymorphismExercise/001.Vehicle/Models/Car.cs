namespace Vehicle.Models;

public class Car : Vehicle
{
    private const double IncreasedFuelConsumption = 0.9;

    public override double FuelConsumption => base.FuelConsumption + IncreasedFuelConsumption;

    public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
    {
    }
}
