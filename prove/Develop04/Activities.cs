using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

public class Activities 
{
    private string _activity;
    
    private string _welcomeMessage;

    private string _description;

    protected int _duration;

    private string _endMessage;

    public Activities(string activity, string description) 
    {
        _activity = activity;
        _welcomeMessage = $"Welcome to the {activity}";
        _description = $"{description}";
        _duration = 0;
        _endMessage = $"You have completed {_duration} seconds of the {_activity}!";
    }

    public void Annimation()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(3);
        while (DateTime.Now <= endTime)
        {
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");
        }
    }

    public void StartMessage() 
    {
        Console.WriteLine($"{_welcomeMessage}\n\n{_description}");
    }

    public void GetDuration() 
    {
        Console.Write($"\nHow long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;
        _endMessage = $"You have completed {_duration} seconds of the {_activity}!";
    }

    public void RunActivity(Action function)
    {
        StartMessage();
        GetDuration();
        Console.Clear();
        Console.WriteLine("Get ready...");
        Annimation();
        function();
        Console.WriteLine("\nWell done!");
        Annimation();
        Console.WriteLine($"\n{_endMessage}");
        Annimation();
        Console.Clear();
    }
}
