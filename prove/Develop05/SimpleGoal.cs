public class SimpleGoal : Goals
{
    public SimpleGoal(string title, string description, int points) : base(title, description, points){}

    public SimpleGoal(string title, string description, int points, bool complete) : base(title, description, points, complete){}

}