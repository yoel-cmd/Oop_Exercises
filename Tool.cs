using System;

public abstract class Tool
{
    protected string _name;
    protected string _weight;


    public Tool(string name,string weight)
    {
        this._name = name;
        this._weight=weight;
    }

    public abstract void Describe();
    

    public abstract void Use();
    

}