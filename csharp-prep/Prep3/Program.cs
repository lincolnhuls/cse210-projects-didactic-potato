using System;

class Program
{
    static void Main(string[] args)
    {   string again = "";
        do {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);
            string helper = "";
            int tries = 0;
            Console.WriteLine("Welcome to the number guesser!");
            do
            {
                Console.WriteLine("What is your guess?");
                string user_guess = Console.ReadLine();
                int guess = int.Parse(user_guess);
                if (guess > number) 
                {
                    helper = "Lower";
                }
                else if (guess < number) 
                {
                    helper = "Higher";
                }
                else 
                {
                    helper = "You guessed it!";
                }
                Console.WriteLine($"{helper}");
                tries += 1;
            } while (helper != "You guessed it!");
            Console.WriteLine($"It took you {tries} tries!");
            Console.WriteLine("Would you like to play again?");
            string answer = Console.ReadLine();
            again = answer.ToLower();
        } while (again !="no");
    }
}