﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public string FirstName
    {
        get => firstName;
        private set
        {
            if (value is null || value.Length < 3)
            {
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }

            firstName = value;
        }
    }

    public string LastName
    {
        get => lastName;
        private set
        {
            if (value is null || value.Length < 3)
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }

            lastName = value;
        }
    }

    public int Age
    {
        get => age;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }

            age = value;
        }
    }

    public decimal Salary
    {
        get => salary;
        private set
        {
            if (value < 650)
            {
                throw new ArgumentException("Salary cannot be less than 650 leva!");
            }

            salary = value;
        }
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
