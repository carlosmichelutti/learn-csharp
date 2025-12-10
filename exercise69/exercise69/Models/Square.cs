namespace exercise69.Models;

internal class Square : GeometricShape
{

    private double _area;
    private double _perimeter;
    public double Side { get; }

    public Square(double side)
    {
        Side = side;
    }

    public override double CalculateArea()
    {
        _area = Side * Side;
        Console.WriteLine($"The area of the square is equal to {_area:F2}");
        return _area;
    }

    public override double CalculatePerimeter()
    {
        _perimeter = Side + Side + Side + Side;
        Console.WriteLine($"The perimeter of the square is equal to {_perimeter:F2}");
        return _perimeter;
    }
}
