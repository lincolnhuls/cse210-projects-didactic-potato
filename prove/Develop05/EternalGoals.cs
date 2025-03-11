public class EternalGoals : Goals
{
    public EternalGoals(string title, string description, int points) : base(title, description, points){}

    public EternalGoals(string title, string description, int points, bool complete) : base(title, description, points, complete){}

    public override void Display()
    {
        Console.WriteLine($"[ ] {_title} ({_description})");
    }
}