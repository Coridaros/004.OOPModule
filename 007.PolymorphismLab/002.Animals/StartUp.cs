//Polymorphism - lab, Task 002
//27.08.2025, 15:39

using Animals;

public class StartUp
{
    static void Main()
    {
        Animal cat = new Cat("Peter", "Whiskas");
        Animal dog = new Dog("George", "Meat");

        Console.WriteLine(cat.ExplainSelf());
        Console.WriteLine(dog.ExplainSelf());
    }
}