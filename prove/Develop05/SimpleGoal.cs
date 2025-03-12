public class SimpleGoal : Goals
{
    private bool _rewardedPoints;

    public SimpleGoal(string title, string description, int points) : base(title, description, points)
    {
        _rewardedPoints = false;
    }

    public SimpleGoal(string title, string description, int points, bool complete) : base(title, description, points, complete)
    {
        _rewardedPoints = false;
    }

    public override void CalcPoints()
    {
        if (!_rewardedPoints && _complete)
        {
            _achievedPoints += _points;
            _rewardedPoints = true;
        }
    }

    public override void IsComplete()
    {
        if (!_complete)
        {
            _complete = true;
            CalcPoints();
        }
    }
}