namespace exercise74.Models;

internal class Rectangle : IShape
{
    private double _area;
    private double _perimeter;
    public double Height { get; }
    public double Width { get; }

    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }

    public double CalculateArea()
    {
        _area = Height * Width;
        Console.WriteLine($"The area of the rectangle is equal to {_area:F2}");
        return _area;
    }

    public double CalculatePerimeter()
    {
        _perimeter = (Height * 2) + (Width * 2);
        Console.WriteLine($"The perimeter of the rectangle is equal to {_perimeter:F2}");
        return _perimeter;
    }
}
