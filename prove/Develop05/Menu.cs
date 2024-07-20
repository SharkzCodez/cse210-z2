class Menu
{

    public int DisplayMenu()
    {
        Console.WriteLine("Welcome to the program");
        Console.WriteLine();
        Console.WriteLine("Please select one of the following options");
        Console.WriteLine("1. Write new goal");
        Console.WriteLine("2. List goals");
        Console.WriteLine("3. Save goal");
        Console.WriteLine("4. Load goal");
        Console.WriteLine("5. Quit");
        return int.Parse(Console.ReadLine());
    }

    public int DisplayCreateGoalMenu()
    {
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");
        Console.WriteLine();
        Console.WriteLine("Please select a goal to set");
        return int.Parse(Console.ReadLine());
    }

    public Goal InterpretChoice(int goalChoice)
    {
        if (goalChoice == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal();
            simpleGoal.RecordEvent();
            return simpleGoal;
        }
        else if (goalChoice == 2)
        {
            EternalGoal eternalGoal = new EternalGoal();
            eternalGoal.RecordEvent();
            return eternalGoal;
        }
        else
        {
            ChecklistGoal checklistGoal = new ChecklistGoal();
            checklistGoal.RecordEvent();
            return checklistGoal;
        }
    }
}