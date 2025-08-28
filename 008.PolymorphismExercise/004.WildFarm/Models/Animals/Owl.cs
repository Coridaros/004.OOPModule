using WildFarm.Models.Food;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Animals;

public class Owl : Bird
{
    private const double OwlWeightMlt = 0.25;

    public override double FoodMultiplayer => OwlWeightMlt;

    public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
    {

    }

    public override bool Eat(IFood food)
    {
        if(food is not Meat)
        {
            return false;
        }

        return base.Eat(food);
    }

    public override string AskForFood()
    {
        return "Hoot Hoot";
    }
}
