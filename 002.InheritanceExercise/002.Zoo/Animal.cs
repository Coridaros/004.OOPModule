namespace Zoo;

public abstract class Animal
{
    private string name;

    public string Name { get; set; }

    protected Animal(string name)
    {
        this.Name = name;
    }
}