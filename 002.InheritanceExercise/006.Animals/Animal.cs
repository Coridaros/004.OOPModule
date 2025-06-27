using System.Text;

namespace Animals;

public abstract class Animal
{
    private string _name;
    private int _age;
    private string _gender;

    public string Name 
    { 
        get
        {
            return this._name;
        }
        private set
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Invalid input!");
            }

            this._name = value;
        }
    }
    public int Age 
    {
        get
        {
            return this._age;
        } 
        private set
        {
            if(value < 0)
            {
                throw new ArgumentException("Invalid input!");
            }

            this._age = value;
        }
    }
    public string Gender
    {
        get
        {
            return this._gender;
        }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Invalid input!");
            }

            this._gender = value;
        }
    }

    public Animal(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    public abstract string ProduceSound();

    public override string ToString()
    {
        return $"{Name} {Age} {Gender}{Environment.NewLine}{ProduceSound()}";
    }
}
