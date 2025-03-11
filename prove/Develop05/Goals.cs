using System.Drawing;

public class Goals 
{
    protected string _title;

    protected string _description;

    protected int _points;

    protected bool _complete;

    public Goals(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
    }

    public Goals(string title, string description, int points, bool complete)
    {
        _title = title;
        _description = description;
        _points = points;
        _complete = complete;
    }

    public virtual void Display()
    {
        if (_complete) 
        {
            Console.WriteLine($"[X] {_title} ({_description})");
        }
        else 
        {
            Console.WriteLine($"[ ] {_title} ({_description})");
        }
    }

    public virtual void Record()
    {
    }

    public virtual bool IsComplete()
    {
        return false;
    }
}