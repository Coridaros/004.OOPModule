﻿//Encapsulation - lab, Task 003
//10.07.2025, 23:48

namespace PersonsInfo;

public class StartUp
{
    static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var persons = new List<Person>();
        for (int i = 0; i < lines; i++)
        {
            var cmdArgs = Console.ReadLine().Split();

            try
            {
                var person = new Person(cmdArgs[0],
                        cmdArgs[1],
                        int.Parse(cmdArgs[2]),
                        decimal.Parse(cmdArgs[3]));

                persons.Add(person);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        var parcentage = decimal.Parse(Console.ReadLine());
        persons.ForEach(p => p.IncreaseSalary(parcentage));
        persons.ForEach(p => Console.WriteLine(p.ToString()));

    }
}
