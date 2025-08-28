using WildFarm.Models.Food;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Animals;

public class Dog : Mammal
{
    private const double DogWeightMlt = 0.40;

    public override double FoodMultiplayer => DogWeightMlt;

    public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {
    }

    public override string AskForFood()
    {
        return "Woof!";
    }

    public override bool Eat(IFood food)
    {
        if(food is not Meat)
        {
            return false;
        }

        return base.Eat(food);
    }

    public override string ToString()
    => base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
}
