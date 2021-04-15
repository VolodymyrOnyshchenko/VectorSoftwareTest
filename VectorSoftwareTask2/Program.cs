using System;
using System.Collections.Generic;
using System.Linq;

public class Shape : IComparable<Shape>
{
    public double Area { get; set; }

    public int CompareTo(Shape any)
    {
        return Area.CompareTo(any.Area);
    }

}

public class Square : Shape
{
    public Square(double side)
    {
        Area = side * side;
    }
}

public class Rectangle : Shape
{
    public Rectangle(double width, double height)
    {
        Area = width * height;
    }
}

public class Triangle : Shape
{
    public Triangle(double Base, double height)
    {
        Area = (Base * height) / 2;
    }
}

public class Circle : Shape
{
    public Circle(double radius)
    {
        Area = (radius * radius) * Math.PI;
    }
}