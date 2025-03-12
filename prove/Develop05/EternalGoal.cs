public class EternalGoal : Goals
{
    public EternalGoal(string title, string description, int points) : base(title, description, points){}

    public EternalGoal(string title, string description, int points, bool complete) : base(title, description, points, complete){}

    public override void Display()
    {
        Console.WriteLine($"[ ] {_title} ({_description})");
    }

    public override void IsComplete()
    {
        _complete = true;
        base.CalcPoints();
        _complete = false;
    }
}