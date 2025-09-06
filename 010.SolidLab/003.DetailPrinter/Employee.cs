using DetailPrinter.Interfaces;

namespace DetailPrinter;

public class Employee : IEmployee
{
    public Employee(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }

    public void PrintDetails()
    {
        Console.WriteLine(Name);
    }
}
