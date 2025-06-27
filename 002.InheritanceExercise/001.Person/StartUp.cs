//Inheritance - exercise, Task 001
//26.06.2025, 23:02

using System;

namespace Person;

public class StartUp
{
    static void Main()
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        if(age > 15)
        {
            Person person = new(name, age);
            Console.WriteLine(person);
        }
        else if(age >= 0)
        {
            Child child = new(name, age);
            Console.WriteLine(child);
        }
        else
        {
            Console.WriteLine("Age must be positive!");
        }
    }
}