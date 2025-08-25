using System.Diagnostics;

namespace ShoppingSpree.Models;

public class Person
{
    private string name;
    private decimal money;
    private List<Product> products;

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }

            name = value;
        }
    }

    public decimal Money
    {
        get => money;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }

            money = value;
        }
    }

    public Person(string name, decimal money)
    {
        Name = name;
        Money = money;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        if(product.Cost > Money)
        {
            Console.WriteLine($"{Name} can't afford {product.Name}");
            return;
        }

        products.Add(product);
        Money -= product.Cost;

        Console.WriteLine($"{Name} bought {product.Name}");
    }

    public override string ToString()
    {
        if(products.Count == 0)
        {
            return $"{Name} - Nothing bought";
        }

        return $"{Name} - {string.Join(", ", products.Select(n => n.Name))}";
    }
}