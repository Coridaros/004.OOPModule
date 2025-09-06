//SOLID - lab, Task 003
//28.08.2025, 15:54

using DetailPrinter.Interfaces;

namespace DetailPrinter;

public class StartUp
{
    static void Main()
    {
        IEmployee employee = new Employee("Pesho");

        IEmployee manager = new Manager("Gosho", new List<string>() { "Financial Report", "Project Details" });

        employee.PrintDetails();
        manager.PrintDetails();
    }
}