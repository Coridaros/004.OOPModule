using WildFarm.Models.Food;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Animals;

public class Mouse : Mammal
{
    private const double MouseWeightMlt = 0.10;

    public override double FoodMultiplayer => MouseWeightMlt;

    public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {
    }

    public override string AskForFood()
    {
        return "Squeak";
    }

    public override bool Eat(IFood food)
    {
        if (food is not Vegetable and not Fruit)
        {
            return false;
        }

        return base.Eat(food);
    }

    public override string ToString()
    => base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
}
