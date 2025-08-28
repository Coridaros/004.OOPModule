using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Animals;

public abstract class Mammal : Animal, IMammal
{
    public string LivingRegion { get; private set; }

    protected Mammal(string name, double weight, string livingRegion) : base(name, weight)
    {
        LivingRegion = livingRegion;
    }
}
