using System;

public class Tool
{
    protected string _name;
    protected string _weight;


    public Tool(string name,string weight)
    {
        this._name = name;
        this._weight=weight;
    }

    public virtual void Describe()
    {
        Console.WriteLine($"The name of the current tool is and its weight is");
    }

    public virtual void Use()
    {
        Console.WriteLine("Tool is being used ");
    }

}