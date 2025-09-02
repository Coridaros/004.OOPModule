//Exceptions and error handling - lab, Task 002
//27.08.2025, 16:57

public class EnterNumbers
{
    static void Main()
    {
        int startNumber = 1;
        List<int> numbers = new List<int>();

        while(true)
        {
            try
            {
                int num = ReadNumber(startNumber, 100);

                numbers.Add(num);

                startNumber = num;
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid Number!");
                continue;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if(numbers.Count == 10)
            {
                break;
            }
        }

        Console.WriteLine(string.Join(", ", numbers));
    }

    static int ReadNumber(int start, int end)
    {
        int number = int.Parse(Console.ReadLine());

        if(number <= start || number >= end)
        {
            throw new Exception($"Your number is not in range {start} - {end}!");
        }

        return number;
    }
}