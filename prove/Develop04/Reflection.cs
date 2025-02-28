public class Reflection : Activities
{
    private List<string> _refelctionQuestions;
    private List<string> _reflectionPrompts;
    public Reflection() : base("Reflection activity", "This activity will help you reflect on times in your life when you have shown stregnth and resilience. This will help you recognize the power you have and how you can use it in other aspects of you life.")
    {
        _reflectionPrompts = new List<string>
        {
            "A time when you faced a challenging situation.",
            "A time when you felt pushed to your limits.",
            "A moment when you felt vulnerable or defeated.",
            "A time when you helped someone else through a tough time.",
            "Personal qualities that helped you navigate difficult times.",
            "A time when you failed or made a mistake but grew from it.",
            "How you react when faced with adversity.",
            "How you tap into your inner strength during tough decisions.",
            "The role of your values in overcoming challenges.",
            "How recognizing your strength and resilience can help in the future."
        };

        _refelctionQuestions = new List<string>
        {
            "How did you feel when it was complete?",
            "What is your favorite thing about this experience?",
            "What did you learn from completing this activity?",
            "What was the most challenging part of the experience?",
            "What surprised you the most during the process?",
            "How did this experience change your perspective on future challenges?",
            "What skills or strengths did you discover in yourself during this activity?",
            "How did you celebrate your success after completing it?",
            "What would you do differently if you had to go through the experience again?",
            "What are you most proud of in this experience?"
        };
    }

    public void ReflectionLoop()
    {
        Random random = new Random();
        int randomIndex = random.Next(_reflectionPrompts.Count);
        string prompt = _reflectionPrompts[randomIndex];
        Console.WriteLine($"Consider the following prompt:\n\n --- {prompt} ---\n\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine($"Now ponder on each of the following questions as they related to this experience.");
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
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now <= endTime)
        {
            foreach (string question in _refelctionQuestions)
            {
                if (DateTime.Now >endTime) break;
                Console.Write($"{question} ");
                base.Annimation();
                Console.WriteLine();
                if (DateTime.Now >endTime) break;
            }
        }
    }
}