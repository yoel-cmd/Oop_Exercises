using System;

public class SawTool : Tool
{
    public SawTool(string name, string weight) : base(name, weight)
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
        Console.WriteLine($"{_name}  A saw is a tool used to cut materials such as wood, metal, or plastic, by means of a serrated blade that moves back and forth or rotates rapidly. ");

    }
}
