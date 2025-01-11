using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage here: ");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);
        string letterGrade = "";
        string passOrFail = "";
        string sign = "";
        int remainder = percentage % 10;
        if (remainder >= 7)
        {
            sign = "+";
        }
        else if (remainder > 3)
        {
            sign = "";
        }
        else
        {
            sign = "-";
        }
        if (percentage > 93)
        {
            sign = "";
        }
        if (percentage < 60)
        {
            sign = "";
        }
        if (percentage >= 90)
        {
            letterGrade = "A";
            passOrFail = "Pass";
        }
        else if (percentage >= 80 && percentage <= 89)
        {
            letterGrade = "B";
            passOrFail = "Pass";
        }
        else if (percentage >= 70 && percentage <= 79)
        {
            letterGrade = "C";
            passOrFail = "Pass";
        }
        else if (percentage >= 60 && percentage <=69)
        {
            letterGrade = "D";
            passOrFail = "Fail";
        }
        else
        {
            letterGrade = "F";
            passOrFail = "Fail";
        }
        Console.WriteLine($"Your letter grade is {letterGrade}{sign}. ");
        Console.WriteLine($"{passOrFail}");
    }
}