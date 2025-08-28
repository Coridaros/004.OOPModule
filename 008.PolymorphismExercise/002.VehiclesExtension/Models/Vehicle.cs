using Vehicles.Models.Interfaces;

namespace Vehicles.Models;

public abstract class Vehicle : IVehicle
{
    private double fuelQuanity;

    public double FuelQuantity 
    {
        get
        {
            return fuelQuanity;
        }
        private set
        {
            if(fuelQuanity > TankCapacity)
            {
                fuelQuanity = 0;
            }

            fuelQuanity = value;
        }
    }
    public virtual double FuelConsumption { get; private set; }
    public double TankCapacity { get; private set; }

    public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        FuelQuantity = fuelQuantity;
        FuelConsumption = fuelConsumption;
        TankCapacity = tankCapacity;
    }

    public bool Drive(double distance)
    {
        return Drive(distance, FuelConsumption);
    }

    public bool Drive(double distance, double fuelConsumption)
    {
        if (FuelQuantity < distance * fuelConsumption)
        {
            return false;
        }

        FuelQuantity -= distance * fuelConsumption;

        return true;
    }

    public virtual bool Refuel(double amount)
    {
        if(amount <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }

        if(FuelQuantity + amount > TankCapacity)
        {
            return false;
        }

        FuelQuantity += amount;

        return true;
    }

    public override string ToString()
    {
        return $"{GetType().Name}: {FuelQuantity:F2}";
    }
}
