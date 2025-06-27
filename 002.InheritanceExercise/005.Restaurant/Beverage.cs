namespace Restaurant;

public abstract class Beverage : Product
{
    public double Millilitters
    {
        get;
        private set;
    }

    public Beverage(string name, decimal price, double milliliters) : base(name, price)
    {
        Millilitters = milliliters;
    }
}