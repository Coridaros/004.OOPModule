using Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars;

public class Tesla : IElectricCar
{
    private string model;
    private string color;
    private int batteries;

    public Tesla(string model, string color, int batteries)
    {
        this.model = model;
        this.color = color;
        this.batteries = batteries;
    }

    public string Model()
    {
        return model;
    }

    public string Color()
    {
        return color;
    }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public int Battery()
    {
        return batteries;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{color} Tesla {model} with {batteries} Batteries");
        sb.AppendLine(Start());
        sb.AppendLine(Stop());

        return sb.ToString().TrimEnd();
    }
}
