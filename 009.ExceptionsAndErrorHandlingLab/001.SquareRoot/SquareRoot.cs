//Exceptions and error handling - lab, Task 001
//27.08.2025, 16:53

public class SquareRoot
{
    static void Main()
    {
        try
        {
            int number = int.Parse(Console.ReadLine());

            if(number < 0)
            {
                throw new ArgumentException("Invalid number.");
            }

            Console.WriteLine(Math.Sqrt(number));
        }
        catch(ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        finally
        {
            Console.WriteLine("Goodbye.");
        }
    }
}