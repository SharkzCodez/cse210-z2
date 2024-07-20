using System;

public class SimpleGoal : Goal
{
    private bool _isComplete = true;
    
    public override void RecordEvent()
    {
        if (_isComplete == true)
        {
            string goalFinished = $"[X]{_shortName} ({_description})";
        }
    }

    public override bool IsComplete()
    {
        Console.WriteLine("Was the goal completed? (Type y for yes and n for no)");
        string status = Console.ReadLine();

        if (status == "y")
        {
            return _isComplete;
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