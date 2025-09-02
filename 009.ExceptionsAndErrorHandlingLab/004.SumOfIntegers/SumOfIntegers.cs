//Exceptions and error handling - lab, Task 004
//27.08.2025, 18:13

public class SumOfIntegers
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        long sum = 0;

        foreach(var item in input)
        {
            try
            {
                int number = int.Parse(item);

                sum += number;
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"The element '{item}' is in wrong format!");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine($"The element '{item}' is out of range!");
            }

            Console.WriteLine($"Element '{item}' processed - current sum: {sum}");
        }

        Console.WriteLine($"The total sum of all integers is: {sum}");
    }
}