using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Animals;

public abstract class Feline : Mammal, IFeline
{
    public string Breed { get; private set; }

    protected Feline(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion)
    {
        Breed = breed;
    }

    public override string ToString()
    {
        return base.ToString() + $"{Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}
