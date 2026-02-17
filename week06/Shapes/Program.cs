using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("red", 6));
        shapes.Add(new Rectangle("blue", 3, 4));
        shapes.Add(new Circle("purple", 3));

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} Area: {shape.GetArea()}");
        }
    }
}