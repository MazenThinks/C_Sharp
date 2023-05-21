using System;

namespace OOP;

public class shape
{
    public int result;
    public double pi = 3.14;

    // Square
    public void Area(int side)
    {
        result = side * side;
        Console.WriteLine("The area of the sqaure is: {0}", result);
    }

    // Rectangle
    public void Area(int length, int width)
    {
        result = length * width;
        Console.WriteLine("The area of the rectangle is: {0}", result);
    }

    // Triangle
    public void Area(double basee, double height)
    {
        double result = (basee * height) / 2;
        Console.WriteLine("The area of the triangle is: {0}", result);
    }

    // Circle
    public void Area(double radius)
    {
        double result = pi * radius * radius;
        Console.WriteLine("The area of the circle is: {0}", result);
    }

}




class Program
{
    static void Main()
    {
        shape area = new shape();
        area.Area(10); // Square
        area.Area(15, 30); // Rectangle
        area.Area(15.7); // Circle
        area.Area(17.8, 22.4); // Triangle
    }
}


