namespace exercise10;

public class Program
{
    public static void Main()
    {
        double pi = 3.14159;
        double radius = 5.0;
        double areaCircle = pi * radius * radius;
        double perimeterCircle = 2 * pi * radius;

        Console.WriteLine($"Radius: {radius:F2}");
        Console.WriteLine($"Area of the circle: {areaCircle:F2}");
        Console.WriteLine($"Perimeter of the circle: {perimeterCircle:F2}");
    }
}