using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        int goalChoice = 0;
        GoalManager goals = new GoalManager();

        Menu menu = new Menu();
        while (userChoice != 5)
        {
            do
            {
                Console.WriteLine();
                goals.DisplayPlayerInfo();
                userChoice = menu.DisplayMenu();
            } while (userChoice > 5 || userChoice < 1);
            if (userChoice == 1)
            {
                do
                {
                    goalChoice = menu.DisplayCreateGoalMenu();
                } while (goalChoice > 3 || goalChoice < 1);
                Goal goal = menu.InterpretChoice(goalChoice);
                goals.CreateGoal();
            }
            else if (userChoice == 2)
            {
                goals.ListGoalNames();
            }
            else if (userChoice == 3)
            {
                goals.SaveGoals();
            }
            else if (userChoice == 4)
            {
                goals.LoadGoals();
            }
        }
    }
}