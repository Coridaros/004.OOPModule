using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Animals;

public class Hen : Bird
{
    private const double HenWeightMlt = 0.35;

    public override double FoodMultiplayer => HenWeightMlt;

    public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
    {
    }

    public override string AskForFood()
    {
        return "Cluck";
    }
}
