//Interfaces and abstraction - exercise, Task 004
//21.08.2025, 00:45

namespace BorderControl;

public class StartUp
{
    static void Main()
    {
        List<IIdentifiable> ids = new List<IIdentifiable>();

        string input;

        while((input = Console.ReadLine()) != "End")
        {
            string[] tokens = input.Split();

            if(tokens.Length == 2)
            {
                IIdentifiable id = new Robot(tokens[0], tokens[1]);
                ids.Add(id);
            }
            else
            {
                IIdentifiable id = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]);
                ids.Add(id);
            }
        }

        string end = Console.ReadLine();

        foreach(var item in ids)
        {
            if(item.Id.EndsWith(end))
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}
