//Reflection and attributes - exercise, Task 002
//07.09.2025, 19:35

using ValidationAttributes.Models;
using ValidationAttributes.Utils;

public class StartUp
{
    static void Main()
    {
        var person = new Person
         (
             null,
             -1
         );

        bool isValidEntity = Validator.IsValid(person);

        Console.WriteLine(isValidEntity);
    }
}