public class GoalManager
{
    private List<Goals> _goals = new List<Goals>();

    private int _totalPoints;

    public GoalManager() {}

    public void SaveFile()
    {
    }

    public void LoadFile()
    {
    }

    public void AddGoal(Goals goal)
    {
        _goals.Add(goal);
    }

    public void CalcPoints() 
    {
        _totalPoints = 0;
        foreach (Goals goal in _goals)
        {
            _totalPoints += goal.GetPoints();
        }
    }

    public void DisplayPoints()
    {
        Console.WriteLine($"Total Points: {_totalPoints}");
    }
}

