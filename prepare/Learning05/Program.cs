using System;
using System.Drawing;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Blue", 15);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Red", 10, 20);
        shapes.Add(s2);

        Circle s3 = new Circle("Yellow", 20);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }

        
    }
}