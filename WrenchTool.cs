using System;

public class WrenchTool : Tool
{
    public WrenchTool(string name, string weight) : base(name, weight)
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
        Console.WriteLine($"{_name}  is used to tighten or loosen screws ");

    }
}
