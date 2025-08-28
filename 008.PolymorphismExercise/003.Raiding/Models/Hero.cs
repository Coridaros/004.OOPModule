using Raiding.Models.Interfaces;

namespace Raiding.Models;

public abstract class Hero : IHero
{
    public string Name { get; private set; }

    public int Power { get; private set; }

    public Hero(string name, int power)
    {
        Name = name;
        Power = power;
    }

    public abstract string CastAbility();
}
