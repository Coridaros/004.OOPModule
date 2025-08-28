using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Animals;

public abstract class Animal : IAnimal
{
    public string Name { get; private set; }

    public double Weight { get; private set; }

    public int FoodEaten { get; private set; }

    public abstract double FoodMultiplayer { get; }

    public Animal(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }

    public virtual bool Eat(IFood food)
    {
        Weight += food.Quantity * FoodMultiplayer;
        FoodEaten += food.Quantity;

        return true;
    }

    public abstract string AskForFood();

    public override string ToString()
    {
        return $"{GetType().Name} [{Name}, ";
    }
}
