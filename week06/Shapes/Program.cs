using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Rojo", 5));
        shapes.Add(new Rectangle("Azul", 4, 6));
        shapes.Add(new Circle("Verde", 3));
        
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area:F2}"); // :F2 determines 2 decimals
        }
    }
}