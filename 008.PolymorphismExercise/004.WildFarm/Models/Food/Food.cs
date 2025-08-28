using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Food;

public abstract class Food : IFood
{
    public int Quantity { get; private set; }

    public Food(int quantity)
    {
        Quantity = quantity;
    }
}
