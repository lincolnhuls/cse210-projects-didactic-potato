using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished:  ");
        List<int> numbers = new List<int>();
        int user_number = 0;
        int smallest_so_far = 1000000;
        int largest_so_far = 0;
        int total = 0;
        do 
        {
            Console.Write("Enter number: ");
            string string_number = Console.ReadLine();
            user_number = int.Parse(string_number);
            numbers.Add(user_number);
        } while (user_number != 0);
        foreach (int number in numbers)
        {
            total += number;
            if (number > 0)
            {
                if (number > largest_so_far)
                {
                    largest_so_far = number;
                }
                if (number < smallest_so_far)
                {
                    smallest_so_far = number;
                }
            }
        }
        numbers.Sort();
        int average_divide = (numbers.Count) - 1;
        float average = (float)total / (float)(average_divide);
        numbers.Remove(0);
        Console.WriteLine($"The total is {total}.");
        Console.WriteLine($"The average is {average}.");
        Console.WriteLine($"The biggest number is {largest_so_far}");
        Console.WriteLine($"The smallest positive number is {smallest_so_far}.");
        Console.WriteLine("Sorted list:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}