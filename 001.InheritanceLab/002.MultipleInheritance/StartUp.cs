//Inheritance - lab, Task 002
//26.06.2025, 22:08

namespace Farm;

public class StartUp
{
    static void Main()
    {
        Console.WriteLine("Animal....");

        Animal animal = new Animal();
        animal.Eat();

        Console.WriteLine();

        Console.WriteLine("Dog...");

        Dog dog = new Dog();
        dog.Eat();
        dog.Bark();

        Console.WriteLine();

        Console.WriteLine("Puppy...");

        Puppy puppy = new Puppy();
        puppy.Eat();
        puppy.Bark();
        puppy.Weep();
    }
}