using System;
using System.Net.NetworkInformation;
using System.Text.Json;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    public void Start()
    {
        
    }

    public void DisplayPlayerInfo()
    {

        Console.WriteLine($"Your current score is...");
    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {
        SimpleGoal simple = new SimpleGoal();
        var g1 = simple.GetName(); simple.GetDescription(); simple.GetPoints();
    }

    public void CreateGoal()
    {
        SimpleGoal sGoal = new SimpleGoal();
        sGoal.SetName();
        sGoal.SetDescription();
        sGoal.SetPoints();
        Console.WriteLine($"[ ] {sGoal.GetName()} = {sGoal.GetPoints()}");
        string g1 = $"{sGoal.GetName()}, {sGoal.GetDescription()}, {sGoal.GetPoints()}";


    }

    public async void SaveGoals()
    {
        string fileName = "GoalProject.json";
        await using FileStream createStream = File.Create(fileName);
        await JsonSerializer.SerializeAsync(createStream, _goals);
        Console.WriteLine(File.ReadAllText(fileName));
    }

    public void LoadGoals()
    {

    }

}