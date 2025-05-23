using System;
interface Shapes
{
    double CalculateArea();
}

public class Circle : Shapes
{
    public double Radius { get; set; }
    public double CalculateArea()
    {
        System.Console.WriteLine("Hi");
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shapes
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double CalculateArea()
    {
        return Width * Height;
    }
}

class calculator
{
    public double getArea(Shapes obj)
    {
        return obj.CalculateArea();
    }
}



public class MyClass
{
    public static void Main(string[] args)
    {
        Circle c1 = new Circle();
        c1.Radius = 7.5;
        calculator cc = new calculator();
        System.Console.WriteLine(cc.getArea(c1));
    }
}

