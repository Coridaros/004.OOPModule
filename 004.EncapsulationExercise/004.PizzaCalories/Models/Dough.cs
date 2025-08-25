namespace PizzaCalories.Models;

public class Dough
{
    private const double BaseCaloriesPerGram = 2.0;

    private Dictionary<string, double> flourCalories = new Dictionary<string, double>
    {
        { "white", 1.5 },
        { "wholegrain", 1.0 }
    };

    private Dictionary<string, double> bakingTechniqueCalories = new Dictionary<string, double>
    {
        { "crispy", 0.9 },
        { "chewy", 1.1 },
        { "homemade", 1.0 }
    };

    private string flourType;
    private string bakingTechnique;
    private double weight;

    public string FlourType
    {
        get => flourType;
        set
        {
            if(!flourCalories.ContainsKey(value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            flourType = value;
        }
    }

    public string BakingTechnique
    {
        get => bakingTechnique;
        set
        {
            if(!bakingTechniqueCalories.ContainsKey(value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            bakingTechnique = value;
        }
    }

    public double Weight
    {
        get => weight;
        set
        {
            if(value < 1 || value > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }

            weight = value;
        }
    }

    public Dough(string flourType, string bakingTechnique, double weight)
    {
        FlourType = flourType;
        BakingTechnique = bakingTechnique;
        Weight = weight;
    }

    public double Calories
    {
        get
        {
            return (BaseCaloriesPerGram * Weight) * flourCalories[flourType.ToLower()] * bakingTechniqueCalories[bakingTechnique.ToLower()];
        }
    }
}
