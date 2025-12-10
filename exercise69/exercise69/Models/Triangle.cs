namespace exercise69.Models;

internal class Triangle : GeometricShape
{

    private double _area;
    private double _perimeter;
    public double Base { get; }
    public double Height { get; }
    public double Side { get; }

    public Triangle(double baseSize, double height, double side)
    {
        Base = baseSize;
        Height = height;
        Side = side;
    }

    public override double CalculateArea()
    {
        _area = (Base * Height) / 2;
        Console.WriteLine($"The area of the triangle is equal to {_area:F2}");
        return _area;
    }

    public override double CalculatePerimeter()
    {
        _perimeter = Side + Side + Side;
        Console.WriteLine($"The perimeter of the triangle is equal to {_perimeter:F2}");
        return _perimeter;
    }
}
