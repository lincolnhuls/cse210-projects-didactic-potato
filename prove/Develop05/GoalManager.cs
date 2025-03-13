using System.Configuration.Assemblies;
using System.Reflection.Metadata;

public class GoalManager
{
    private List<Goals> _goals = new List<Goals>();

    private int _totalPoints;

    public GoalManager() {}

    public void SaveFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            CalcPoints();
            outputFile.WriteLine($"{_totalPoints}");
            foreach (Goals goal in _goals)
            {
                outputFile.WriteLine($"{goal.SaveFormat()}");
            }
        }
    }

    public void LoadFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        _totalPoints = int.Parse(lines[0]);
        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split('~');
            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), bool.Parse(parts[5]));
                _goals.Add(goal);
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                _goals.Add(goal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
                _goals.Add(goal);
            }
        }
    }

    public void AddGoal(Goals goal)
    {
        _goals.Add(goal);
    }

    public int CalcPoints() 
    {
        _totalPoints = 0;
        foreach (Goals goal in _goals)
        {
            _totalPoints += goal.GetAchievedPoints();
        }
        return _totalPoints;
    }

    public void DisplayGoals()
    {
        foreach (Goals goal in _goals)
        {
            goal.Display();
        }
    }

    public void DisplayGoalTitle()
    {
        int i = 1;
        foreach (Goals goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetTitle()}");
            i++;
        }
    }

    public void Record(int index)
    {
        int updated_index = index - 1;
        if (updated_index >=0 && updated_index < _goals.Count)
        {
            _goals[updated_index].IsComplete();
        }
        else 
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public int GetGoalPoints(int index)
    {
        int updated_index = index - 1;
        return _goals[updated_index].GetPoints();
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }
}

