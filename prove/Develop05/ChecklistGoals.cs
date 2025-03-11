public class ChecklistGoals : Goals
{
    private int _bonusPoints;

    private int _desiredAmount;

    private int _currentAmount;

    public ChecklistGoals(string title, string description, int points, int bonusPoints, int desiredAmount, int currentAmount) : base(title, description, points)
    {
        _bonusPoints = bonusPoints;
        _desiredAmount = desiredAmount;
        _currentAmount = currentAmount;
    }

    public ChecklistGoals(string title, string description, int points, bool complete, int bonusPoints, int desiredAmount, int currentAmount) : base(title, description, points, complete)
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
}