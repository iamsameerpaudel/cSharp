using System.Collections.Generic;
using System;
static class Circle
{
    public static double area(double radius)
    {
        return Math.PI * radius * radius;
    }
    public static double circumference(double radius)
    {
        return 2 * Math.PI * radius;
    }
    public static double diameterFromRadius(double radius)
    {
        return 2 * radius;
    }
    public static double radiusFromDiameter(double diameter)
    {
        return diameter / 2;
    }
    public static double sectorArea(double angle, double radius)
    {
        double sector = (angle / 360) * (Math.PI * radius * radius);
        return sector;
    }
    public static double radiusFromArea(double area)
    {
        return Math.Sqrt(area / Math.PI);
    }
    public static double arcLength(double angle, double radius)
    {
        double arcLength = (angle / 360) * (2 * Math.PI * radius);
        return arcLength;
    }
    public static double perimeterOfASector(double radius, double arcLength)
    {
        return (2 * radius) + arcLength;
    }
    public static double perimeterOfASector(float angle, double radius)
    {
        double perimeterOfASector = (2 * radius) + ((angle / 360) * 2 * Math.PI * radius);
        return perimeterOfASector;
    }
    public static string equationOfCircle(double h, double k, double radius)
    {
        return $"(x-{h})^2 + (y-{k})^2 = {radius * radius}";
    }
    public static void generateCircle(int numberOfPoints, double radius, int centerX = 0, int centerY = 0)
    {
        ScottPlot.Plot myPlot = new();
        List<double> pointX = new List<double>();
        List<double> pointY = new List<double>();
        for (int i = 0; i < numberOfPoints; i++)
        {
            double angle = 2 * Math.PI * i / numberOfPoints;
        double x = radius * Math.Cos(angle) + centerX;
        double y = radius * Math.Sin(angle) + centerY;
        pointX.Add(Math.Round(x, 3));
        pointY.Add(Math.Round(y, 3));
        }
        myPlot.Add.Scatter(pointX, pointY);
        myPlot.SavePng("circle.png", 500, 500);
        System.Console.WriteLine("Generated Circle");
        System.Console.WriteLine("The points are: ");
        for (int i = 0; i < pointX.Count; i++)
        {
            System.Console.WriteLine($"({pointX[i]}, {pointY[i]})");
        }
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        // Console.WriteLine(Circle.area(5));
        // var perimeter = Circle.perimeterOfASector(angle: 25, 5);
        // var otherPerimeter = Circle.perimeterOfASector(radius: 5, Circle.arcLength(angle: 25, 5));
        // var eqn = Circle.equationOfCircle(5, 7, 14);
        // System.Console.WriteLine(perimeter);
        // System.Console.WriteLine(otherPerimeter);
        // System.Console.WriteLine(eqn);
        Circle.generateCircle(190, 17,17,98);
    }
}