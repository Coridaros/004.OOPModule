namespace PizzaCalories.Models;

public class Pizza
{
    private string name;
    private Dough dough;
    private List<Topping> toppingsList;

    public string Name
    {
        get => name;
        private set
        {
            name = value;
        }
    }
}
