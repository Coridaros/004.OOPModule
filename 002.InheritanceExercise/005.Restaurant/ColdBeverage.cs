﻿namespace Restaurant;

public abstract class ColdBeverage : Beverage
{
    public ColdBeverage(string name, decimal price, double milliliters) : base(name, price, milliliters)
    {
    }
}
