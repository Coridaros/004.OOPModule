using Vehicle.Models.Interfaces;

namespace Vehicle.Models;

public abstract class Vehicle : IVehicle
{
    public double FuelQuantity { get; private set; }

    public virtual double FuelConsumption { get; private set; }

    public Vehicle(double fuelQuantity, double fuelConsumption)
    {
        FuelQuantity = fuelQuantity;
        FuelConsumption = fuelConsumption;
    }

    public bool Drive(double distance)
    {
        if(FuelConsumption * distance < FuelQuantity)
        {
            FuelQuantity -= distance * FuelConsumption;

            return true;
        }

        return false;
    }

    public virtual void Refuel(double litters)
    {
        FuelQuantity += litters;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {FuelQuantity:F2}";
    }
}
