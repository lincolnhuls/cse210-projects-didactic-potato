using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        } 
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string user_number = Console.ReadLine();
            int number = int.Parse(user_number);
            return number;
        }
        static int SquareNumber(int number)
        {
            int squared_number = number * number;
            return squared_number;
        }
        static void DisplayResults(string name, int number) 
        {
            Console.WriteLine($"{name}, the square of your favorite number is {number}.");
        }
        static void Main()
        {
            DisplayMessage();
            string name = PromptUserName();
            int number = PromptUserNumber();
            int squared_number = SquareNumber(number);
            DisplayResults(name, squared_number);
        }
        Main();
    }
}