using WildFarm.Models.Food;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Animals;

public class Cat : Feline
{
    private const double CatWeightMlt = 0.30;

    public override double FoodMultiplayer => CatWeightMlt;

    public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
    {
    }

    public override string AskForFood()
    {
        return "Meow";
    }

    public override bool Eat(IFood food)
    {
        if (food is not Vegetable and not Meat)
        {
            return false;
        }

        return base.Eat(food);
    }
}
