namespace exercise57.Models;

internal class Rectangle
{
    private double _area;
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
        return _area;
    }
}
