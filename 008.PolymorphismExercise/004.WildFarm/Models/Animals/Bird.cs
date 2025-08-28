using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Animals;

public abstract class Bird : Animal, IBird
{
    public double WingSize { get; private set; }

    protected Bird(string name, double weight, double wingSize) : base(name, weight)
    {
        WingSize = wingSize;
    }

    public override string ToString()
    {
        return base.ToString() + $"{WingSize}, {Weight}, {FoodEaten}]";
    }
}
