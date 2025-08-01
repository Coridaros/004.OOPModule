﻿//Encapsulation - lab, Task 004
//11.07.2025, 00:04

using System;

namespace PersonsInfo;

public class StartUp
{
    static void Main(string[] args)
    {
        var lines = int.Parse(Console.ReadLine());
        var persons = new List<Person>();
        for (int i = 0; i < lines; i++)
        {
            try
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        decimal.Parse(cmdArgs[3]));

                persons.Add(person);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        Team team = new Team("SoftUni");

        foreach (Person person in persons)
        {
            team.AddPlayer(person);
        }

        Console.WriteLine(team.ToString());
    }
}
