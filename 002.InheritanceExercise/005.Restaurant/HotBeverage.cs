﻿namespace Restaurant;

public abstract class HotBeverage : Beverage
{
    public HotBeverage(string name, decimal price, double milliliters) : base(name, price, milliliters)
    {
    }
}
