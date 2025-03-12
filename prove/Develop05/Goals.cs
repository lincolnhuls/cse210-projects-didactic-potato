using System.Drawing;

public class Goals 
{
    protected string _title;

    protected string _description;

    protected int _points;

    protected int _achievedPoints;

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

    public int GetPoints()
    {
        return _achievedPoints;
    }

    public virtual void IsComplete()
    {
        _complete =  false;
    }

    public virtual void CalcPoints()
    {
        if (_complete)
        {
            _achievedPoints += _points;
        }
    }

    public void SetComplete()
    {
        _complete = true;
    }
}