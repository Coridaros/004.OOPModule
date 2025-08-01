﻿namespace PlayersAndMonsters;

public abstract class Hero
{
    private string username;
    private int level;

    public string Username { get; set; }
    public int Level { get; set; }

    public Hero(string username, int level)
    {
        this.Username = username;
        this.Level = level;
    }

    public override string ToString()
    {
        return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
    }
}