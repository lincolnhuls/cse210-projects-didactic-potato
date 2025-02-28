using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string again = "y";
        while (again == "y")
        {
            Console.Write("Menu Options:\n  1. Start breathing activity\n  2. Start reflection activity\n  3. Start listing activity\n  4. Quit\nSelect a choice from the menu: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Breathe breathe = new Breathe();
                Console.Clear();
                breathe.RunActivity(breathe.BreathingLoop);
            }
            else if (choice == "2")
            {
                Reflection reflection = new Reflection();
                Console.Clear();
                reflection.RunActivity(reflection.ReflectionLoop);
            }
            else if (choice == "3")
            {
                Lister lister = new Lister();
                Console.Clear();
                lister.RunActivity(lister.ListerLoop);
            }
            else if (choice == "4")
            {
                again = "n";
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}