using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create a list to hold shapes
        List<Shape> shapes = new List<Shape>();

        // Add different shapes to the list
        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 6));
        shapes.Add(new Circle("Green", 3));

        // Iterate through list and display color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Shape Color: " + shape.GetColor());
            Console.WriteLine("Area: " + shape.GetArea());
            Console.WriteLine("----------------------");
        }
    }
}
