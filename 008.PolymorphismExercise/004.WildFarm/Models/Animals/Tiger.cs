using WildFarm.Models.Food;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Animals;

public class Tiger : Feline
{
    public const double TigerWeightMlt = 1.00;

    public override double FoodMultiplayer => TigerWeightMlt;

    public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
    {
    }

    public override string AskForFood()
    {
        return "ROAR!!!";
    }

    public override bool Eat(IFood food)
    {
        if (food is not Meat)
        {
            return false;
        }

        return base.Eat(food);
    }
}
