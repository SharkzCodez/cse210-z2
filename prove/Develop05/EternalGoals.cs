using System;
using System.ComponentModel;

public class EternalGoal : Goal
{
    public override void RecordEvent()
    {
        string goalFinished = $"[ ] {_shortName} ({_description})";
    }

    public override bool IsComplete()
        {
        Console.WriteLine("Was the goal completed? (Type y for yes and n for no)");
        string status = Console.ReadLine();

        if (status == "y")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        string details = $"[ ]{_shortName} ({_description})";

        return details;
    }
}