using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public string GetName()
    {
        return _shortName;
    }

    public void SetName()
    {
        Console.WriteLine("What is the name of your goal? ");
        _shortName = Console.ReadLine();
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription()
    {
        Console.WriteLine("What is a short description of your goal? ");
        _description = Console.ReadLine();
    }

    public string GetPoints()
    {
        return _points;
    }

    public void SetPoints()
    {
        Console.WriteLine("How many points is this goal worth? ");
        _points = Console.ReadLine();
    }

    public abstract string GetStringRepresentation();
}