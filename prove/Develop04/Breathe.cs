public class Breathe : Activities
{
    public Breathe() : base("Breathing activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void BreathingLoop()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now <= endTime)
        {
            Console.Write("\nBreathe in...4");
            if (DateTime.Now >endTime) break;
            Thread.Sleep(1000);
            Console.Write("\b \b3");
            if (DateTime.Now >endTime) break;
            Thread.Sleep(1000);
            Console.Write("\b \b2");
            if (DateTime.Now >endTime) break;
            Thread.Sleep(1000);
            Console.Write("\b \b1");
            if (DateTime.Now >endTime) break;
            Thread.Sleep(1000);
            Console.Write("\b \b");
            if (DateTime.Now >endTime) break;

            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            if (DateTime.Now >endTime) break;

            Console.Write("\nBreathe out...4");
            if (DateTime.Now >endTime) break;
            Thread.Sleep(1000);
            Console.Write("\b \b3");
            if (DateTime.Now >endTime) break;
            Thread.Sleep(1000);
            Console.Write("\b \b2");
            if (DateTime.Now >endTime) break;
            Thread.Sleep(1000);
            Console.Write("\b \b1");
            if (DateTime.Now >endTime) break;
            Thread.Sleep(1000);
            Console.Write("\b \b\n");
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            if (DateTime.Now >endTime) break;
        }
    }
}
