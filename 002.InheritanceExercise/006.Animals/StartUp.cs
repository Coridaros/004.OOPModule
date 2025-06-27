//Inheritance - exercise, Task 006
//28.06.2025, 00:03

namespace Animals;

public class StartUp
{
    static void Main()
    {
        string command = string.Empty;

        while((command = Console.ReadLine()) != "Beast!")
        {
            string[] tokens = Console.ReadLine().Split();
            string name = tokens[0];
            int age = int.Parse(tokens[1]);
            string gender = tokens[2];

            try
            {
                if(command == "Cat")
                {
                    Cat cat = new Cat(name, age, gender);
                    PrintAnimal(command, cat);
                }
                else if(command == "Dog")
                {
                    Dog dog = new Dog(name, age, gender);
                    PrintAnimal(command, dog);
                }
                else if(command == "Frog")
                {
                    Frog frog = new Frog(name, age, gender);
                    PrintAnimal(command, frog);
                }
                else if(command == "Kitten")
                {
                    Kitten kitten = new Kitten(name, age);
                    PrintAnimal(command, kitten);
                }
                else if(command == "Tomcat")
                {
                    Tomcat tomcat = new Tomcat(name, age);
                    PrintAnimal(command, tomcat);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    static void PrintAnimal<T>(string animalType, T animal) where T : Animal
    {
        Console.WriteLine(animalType);
        Console.WriteLine(animal);
    }
}