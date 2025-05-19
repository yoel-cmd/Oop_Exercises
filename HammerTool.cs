using System;

public class HammerTool:Tool {

    public HammerTool(string name,string weight):base(name, weight)
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
        Console.WriteLine($"{_name}  is used to deliver forceful blows to drive nails, shape materials, or break objects. ");
    }


}
