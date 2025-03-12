using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        ChecklistGoal checklistGoal = new ChecklistGoal("Checklist Goal", "Complete the checklist", 10, 5, 3);
        goalManager.AddGoal(checklistGoal);
        goalManager.CalcPoints();
        goalManager.DisplayPoints();
        checklistGoal.IsComplete();
        goalManager.CalcPoints();   
        goalManager.DisplayPoints();
        checklistGoal.IsComplete();  
        goalManager.CalcPoints();
        goalManager.DisplayPoints();
        checklistGoal.IsComplete();
        goalManager.CalcPoints();   
        goalManager.DisplayPoints();
        checklistGoal.IsComplete();  
        goalManager.CalcPoints();
        goalManager.DisplayPoints();
        checklistGoal.IsComplete();  
        goalManager.CalcPoints();
        goalManager.DisplayPoints();
    }
}