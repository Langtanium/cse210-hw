using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>()
        {
            new Square("red", 2.5),
            new Rectangle("green", 6.1, 3.4),
            new Circle("blue", 7.8)
        };

        foreach (Shape shape in shapeList)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The shape is {color} and has an area of {area}");
        }
    }
}