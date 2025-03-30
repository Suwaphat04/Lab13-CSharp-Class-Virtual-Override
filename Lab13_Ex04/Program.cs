using System;

public interface IShape
{
    double Area();
}

public class Circle : IShape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : IShape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Area()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        IShape shape1 = new Circle(5);
        IShape shape2 = new Rectangle(4, 6);

        Console.WriteLine($"Circle Area: {shape1.Area()}");
        Console.WriteLine($"Rectangle Area: {shape2.Area()}");
    }
}
