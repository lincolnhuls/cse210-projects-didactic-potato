public class Lister : Activities
{
    private List<string> _listPrompts;

    public Lister() : base("Listing activity", "This activity will help you relfect on the good things in your life by having you list as many things as you ca nin a certian area.")
    {
        _listPrompts = new List<string>
        {
            "When have you felt the Holy Ghost this month?",
            "When have you experienced peace or comfort through the Spirit this week?",
            "Can you recall a moment this month when you felt guided by the Holy Ghost?",
            "How has the Holy Ghost helped you make a decision recently?",
            "When did you feel inspired by the Holy Ghost to help someone?",
            "Have you felt the Holy Ghost during your personal scripture study this month?",
            "When was a time this month that you felt the Holy Ghost during prayer?",
            "Can you remember a time this month when the Spirit helped you feel love or compassion?",
            "When did the Holy Ghost strengthen you in a difficult moment this month?",
            "How has the Holy Ghost helped you recognize truth in the past few weeks?"
        };
    }

    public void ListerLoop()
    {
        Random random = new Random();
        int randomIndex = random.Next(_listPrompts.Count);
        string prompt = _listPrompts[randomIndex];
        Console.WriteLine($"\nList as many responses you can to the following prompt:\n --- {prompt} ---");
        Console.Write($"You may begin in: 5");
        Thread.Sleep(1000);
        Console.Write("\b \b4");
        Thread.Sleep(1000);
        Console.Write("\b \b3");
        Thread.Sleep(1000);
        Console.Write("\b \b2");
        Thread.Sleep(1000);
        Console.Write("\b \b1");
        Thread.Sleep(1000);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int count = 0;
        while (DateTime.Now <= endTime)
        {
            if (DateTime.Now >endTime) break;
            Console.Write("> ");
            Console.ReadLine();
            count++;
            if (DateTime.Now >endTime) break;
        }
        Console.WriteLine($"\nYou listed {count} items!");
    }
}