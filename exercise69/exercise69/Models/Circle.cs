namespace exercise69.Models;

internal class Circle : GeometricShape
{

    private double _pi => 3.14;
    private double _area;
    private double _perimeter;
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        _area = _pi * (Radius * Radius);
        Console.WriteLine($"The area of the circle is equal to {_area:F2}");
        return _area;
    }

    public override double CalculatePerimeter()
    {
        _perimeter = 2 * _pi * Radius;
        Console.WriteLine($"The perimeter of the circle is equal to {_perimeter:F2}");
        return _perimeter;
    }
}
