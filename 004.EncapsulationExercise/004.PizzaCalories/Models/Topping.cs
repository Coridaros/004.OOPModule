namespace PizzaCalories.Models;

public class Topping
{
    private const double BaseCaloriesPerGram = 2.0;

    private string type;
    private double weight;

    private Dictionary<string, double> typeCalories = new Dictionary<string, double>
    {
        { "meat", 1.2 },
        { "veggies", 0.8 },
        { "cheese", 1.1 },
        { "sauce", 0.9 }
    };

    public string Type
    {
        get => type;
        private set
        {
            if(!typeCalories.ContainsKey(value.ToLower()))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }

            type = value;
        }
    }

    public double Weight
    {
        get => weight;
        set
        {
            if(value < 1 || value > 50)
            {
                throw new ArgumentException($"{Type} weight should be in the range [1..50].");
            }
            weight = value;
        }
    }

    public Topping(string type, double weight)
    {
        Type = type;
        Weight = weight;
    }

    public double ToppingCalories
    {
        get { return BaseCaloriesPerGram * Weight * typeCalories[Type.ToLower()]; }
    }
}
