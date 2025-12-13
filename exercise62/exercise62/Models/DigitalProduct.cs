namespace exercise62.Models;

internal class DigitalProduct
{
    public string Name { get; }
    public double Price { get; }
    public TechnicalInformation TechnicalInformation { get; }

    public DigitalProduct(string name, double price, TechnicalInformation technicalInformation)
    {
        Name = name;
        Price = price;
        TechnicalInformation = technicalInformation;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Product: {Name}");
        Console.WriteLine($"Price: ${Price:F2}");
        Console.WriteLine($"Size: {TechnicalInformation.SizeMB:F2}");
        Console.WriteLine($"Compatible with: {TechnicalInformation.OperatingSystem}");
    }
}
