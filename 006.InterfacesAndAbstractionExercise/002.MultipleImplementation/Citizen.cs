namespace PersonInfo;

public class Citizen : IBirthable, IIdentifiable, IPerson
{
    public string Birthdate { get; private set; }

    public string Id { get; private set; }

    public string Name { get; private set; }

    public int Age { get; private set; }

    public Citizen(string name, int age, string id, string birthDate)
    {
        Name = name;
        Age = age;
        Id = id;
        Birthdate = birthDate;
    }
}
