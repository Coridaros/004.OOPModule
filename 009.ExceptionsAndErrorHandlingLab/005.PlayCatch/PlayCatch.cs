//Exceptions and error handling - lab, Task 004
//27.08.2025, 18:30

public class PlayCatch
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        List<int> result = new List<int>();

        int exCnt = 0;

        while(true)
        {
            if(exCnt == 3)
            {
                break;
            }

            try
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Replace")
                {
                    int index = int.Parse(command[1]);
                    int elemnt = int.Parse(command[2]);

                    numbers[index] = elemnt;
                }
                else if (command[0] == "Print")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        result.Add(numbers[i]);
                    }

                    Console.WriteLine(string.Join(", ", result));
                }
                else if (command[0] == "Show")
                {
                    int index = int.Parse(command[1]);

                    Console.WriteLine(numbers[index]);
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("The variable is not in the correct format!");
                exCnt++;
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("The index does not exist!");
                exCnt++;
            }
        }

        Console.WriteLine(string.Join(", ", numbers));
    }
}