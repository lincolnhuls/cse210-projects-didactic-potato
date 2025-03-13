using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        while (true)
        {
            Console.WriteLine($"You have {goalManager.GetTotalPoints()} points.");

            Console.WriteLine($"\nMenu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit\nSelect a choice from the menu: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine($"The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\nWhich type of goal would you like to create?  ");
                string goalChoice = Console.ReadLine();
                Console.WriteLine("What is the name of your goal? ");
                string title = Console.ReadLine();
                Console.WriteLine("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());
                if (goalChoice == "1")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(title, description, points);
                    goalManager.AddGoal(simpleGoal);
                }
                else if (goalChoice == "2")
                {
                    EternalGoal eternalGoal = new EternalGoal(title, description, points);
                    goalManager.AddGoal(eternalGoal);
                }
                else if (goalChoice == "3")
                {
                    Console.WriteLine($"How many times does this goal need to be accomplished for a bonus? ");
                    int times = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());
                    ChecklistGoal checklistGoal = new ChecklistGoal(title, description, points, bonus, times);
                    goalManager.AddGoal(checklistGoal);
                }
            }
            else if (choice == "2") 
            {
                Console.WriteLine($"The goals are:");
                goalManager.DisplayGoals();
            } 
            else if (choice == "3") 
            {
                Console.WriteLine($"What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                goalManager.SaveFile(filename);
            } 
            else if (choice == "4") 
            {
                Console.WriteLine($"What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                goalManager.LoadFile(filename);
            } 
            else if (choice == "5") 
            {
                Console.WriteLine("The goals are:");
                goalManager.DisplayGoalTitle();
                Console.WriteLine("Which goal did you accomplish? ");
                int accomplished = int.Parse(Console.ReadLine());
                goalManager.Record(accomplished);
                Console.WriteLine($"Congratulations! You have earned {goalManager.GetGoalPoints(accomplished)} points!");
                Console.WriteLine($"You now have {goalManager.CalcPoints()} points.\n");
            } 
            else if (choice == "6")
            {
                break;
            } 
        }
    }
}