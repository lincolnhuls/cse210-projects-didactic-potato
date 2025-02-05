using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

// dotnet new console --use-program-main -o {project name}
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to your journal!");
        string user_input = "";
        do 
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Load journal from file");
            Console.WriteLine("4. Save journal to file");
            Console.WriteLine("5. Quit");
            user_input = Console.ReadLine();
            if (user_input == "1") 
            {
                WriteJournal(journal);
            }
            if (user_input == "2") 
            {
                journal.Display();
            }
            if (user_input == "3") 
            {
                LoadJournal(journal);
            }
            if (user_input == "4")
            {
                SaveJournal(journal);
            }
        } while (user_input != "5");
    }
    static void WriteJournal(Journal journal) 
    {
        string prompt = Prompt();
        Console.WriteLine(prompt);
        string text = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        Entry entry = new Entry();
        entry._prompt = prompt;
        entry._entryDateTime = date;
        entry._entryText = text;
        journal._entries.Add(entry);
    }
    static void SaveJournal(Journal journal)
    {
        Console.WriteLine("What would you like to save the journal as? ");
        string filename = Console.ReadLine();
        journal.Write(filename);
    }
    static void LoadJournal(Journal journal)
    {
        Console.WriteLine("What is the filename of the journal you would like to load? ");
        string filename = Console.ReadLine();
        journal.Load(filename);
    }
    static string Prompt()
    {
        List<string> prompts = new List<string> 
        {
            "What are three things am I most grateful for today, and why?",
            "What made me smile or laugh today?",
            "What is one thing I accomplished today that I feel proud of?",
            "What challenge did I face today, and how did I handle it?",
            "What is one moment from today I want to remember forever?",
            "How did I show kindness to myself or others today?",
            "What is something I learned or discovered today?",
            "If I could change one thing about today, what would it be and why?",
            "What did I do today to move closer to one of my goals?",
            "What energized me today, and what drained me?",
            "What is something I noticed about the world around me today?",
            "What is one thing I can do tomorrow to make it a great day?",
            "How did I feel throughout the day, and what might have influenced my emotions?",
            "What is one habit or action I want to focus on improving tomorrow?",
            "What is one thing I'm looking forward to about tomorrow?"
        };
        int legnth = prompts.Count;
        Random random = new Random();
        int index = random.Next(0, legnth);
        string prompt = prompts[index];
        return prompt;
    }
}