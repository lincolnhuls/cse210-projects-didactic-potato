using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scritpure Memorizer! \nWould you like to enter your own scripture? [Yes/No]");
        string user_input = Console.ReadLine().ToUpper();
        if (user_input == "YES")
        {
            Console.WriteLine("Please enter the refrence book: ");
            string book = Console.ReadLine();
            Console.WriteLine("Please enter the chapter: ");
            int chapter = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the first verse: ");
            int firstVerse = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the last verse (If there is only one verse enter the same verse): ");
            int lastVerse = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the text: ");
            string text = Console.ReadLine();
            Refrence newRefrence = new Refrence(book, chapter, firstVerse, lastVerse, text);
            Scripture scripture = new Scripture(newRefrence);
            string go = "";
            while (go != "QUIT")
            {
                go = scripture.Display();
                if (go.ToUpper() == "QUIT")
                {
                    break;
                }
                scripture.HideWord();
                go = scripture.CompletelyHidden();
                if (go == "QUIT")
                {
                    scripture.Display();
                }
            }
        }
        else 
        {
            Refrence refrence = new Refrence();
            Scripture scripture = new Scripture(refrence);
            string go = "";
            while (go != "QUIT")
            {
                go = scripture.Display();
                if (go.ToUpper() == "QUIT")
                {
                    break;
                }
                scripture.HideWord();
                go = scripture.CompletelyHidden();
                if (go == "QUIT")
                {
                    scripture.Display();
                }
            }
        }
    }
}