using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();

        Fraction fraction2 = new Fraction(5);

        Fraction fraction3 = new Fraction(3, 4);

        Fraction fraction4 = new Fraction(1, 3);

        // Console.Write("Please enter the top number of the fraction here: ");
        // int top_number = int.Parse(Console.ReadLine());
        // Console.Write("Please enter the bottom number of the fraction here: ");
        // int bottom_number = int.Parse(Console.ReadLine());
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());
    }
}