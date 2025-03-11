using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of each class with complete set to false
        SimpleGoal simpleGoal = new("Simple Goal", "This is a simple goal", 10);
        ChecklistGoals checklistGoal = new("Checklist Goal", "This is a checklist goal", 50, 100, 3, 0);
        EternalGoals eternalGoal = new("Eternal Goal", "This is an eternal goal", 15);

        // Create instances of each class with complete set to true
        SimpleGoal completedSimpleGoal = new("Completed Simple Goal", "This is a completed simple goal", 10, true);
        ChecklistGoals completedChecklistGoal = new("Completed Checklist Goal", "This is a completed checklist goal", 50, 100, 3, 5);
        EternalGoals completedEternalGoal = new("Completed Eternal Goal", "This is a completed eternal goal", 15, true);

        // Display each goal
        simpleGoal.Display();
        checklistGoal.Display();
        eternalGoal.Display();

        // Display each completed goal
        completedSimpleGoal.Display();
        completedChecklistGoal.Display();
        completedEternalGoal.Display();
    }
}