using DetailPrinter.Interfaces;

namespace DetailPrinter;

public class DetailsPrinters
{
    private IList<Employee> employees;

    public DetailsPrinters(IList<Employee> employees)
    {
        this.employees = employees;
    }

    public void PrintDetails()
    {
        foreach (IEmployee employee in employees)
        {
            employee.PrintDetails();
        }
    }
}