﻿namespace PersonsInfo;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public string FirstName
    {
        get;
        private set;
    }

    public string LastName
    {
        get;
        private set;
    }

    public int Age
    {
        get;
        private set;
    }

    public decimal Salary
    {
        get;
        private set;
    }

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Salary = salary;
    }

    public void IncreaseSalary(decimal percentage)
    {
        if (this.Age > 30)
        {
            this.Salary += this.Salary * percentage / 100;
        }
        else
        {
            this.Salary += this.Salary * percentage / 200;
        }
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} receives {Salary:F2} leva.";
    }
}
