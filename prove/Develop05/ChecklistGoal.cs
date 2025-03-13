using System.ComponentModel.DataAnnotations.Schema;

public class ChecklistGoal : Goals
{
    private int _bonusPoints;

    private int _desiredAmount;

    private int _currentAmount;

    public ChecklistGoal(string title, string description, int points, int bonusPoints, int desiredAmount) : base(title, description, points)
    {
        _bonusPoints = bonusPoints;
        _desiredAmount = desiredAmount;
        _currentAmount = 0;
    }

    public ChecklistGoal(string title, string description, int points, bool complete, int bonusPoints, int desiredAmount) : base(title, description, points, complete)
    {
        _bonusPoints = bonusPoints;
        _desiredAmount = desiredAmount;
        _currentAmount = 0;
    }

    public ChecklistGoal(string title, string description, int points, bool complete, int bonusPoints, int desiredAmount, int currentAmount) : base(title, description, points, complete)
    {
        _bonusPoints = bonusPoints;
        _desiredAmount = desiredAmount;
        _currentAmount = currentAmount;
    }

    public override void Display()
    {
        if (_currentAmount >= _desiredAmount)
        {
            Console.WriteLine($"[X] {_title} ({_description}) -- Currently Completed: {_currentAmount}/{_desiredAmount}");
        }
        else
        {
            Console.WriteLine($"[ ] {_title} ({_description}) -- Currently Completed: {_currentAmount}/{_desiredAmount}");
        }
    }

    public override void CalcPoints()
    {
        if (_currentAmount < _desiredAmount)
        {
            _achievedPoints += _points;
        }
        else if (_currentAmount == _desiredAmount)
        {
            _achievedPoints += _points + _bonusPoints;
            _complete = false;
        }
    }

    public override void IsComplete()
    {
        _currentAmount++;
        CalcPoints();
    }

    public override string SaveFormat()
    {
        return $"ChecklistGoal~{_title}~{_description}~{_points}~{_complete}~{_bonusPoints}~{_desiredAmount}~{_currentAmount}";
    }
}