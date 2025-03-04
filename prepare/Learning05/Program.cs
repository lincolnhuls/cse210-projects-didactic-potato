using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle("Red", 2.0));
        shapes.Add(new Rectangle("Blue", 2.0, 3.0));
        shapes.Add(new Square("Green", 2.0));
        shapes.Add(new Circle("Yellow", 3.0));
        shapes.Add(new Rectangle("Black", 3.0, 4.0));
        shapes.Add(new Square("White", 3.0));
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}