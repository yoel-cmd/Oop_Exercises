using System;

public class DrillTool : Tool
{
    public DrillTool(string name, string weight) : base(name, weight)
    {
        this._name = name;
        this._weight = weight;
    }

    public override void Describe()
    {
        Console.WriteLine($"The name of the current is:{_name} tool is and its weight is: {_weight}");

    }


    public override void Use()
    {
        Console.WriteLine($"{_name} is a tool that creates holes in various materials by rotating a bit at high speed. ");

    }
}
