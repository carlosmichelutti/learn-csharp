namespace Exercise62.Models;

public class DigitalProduct
{
    public string Name { get; set; }
    public double Price { get; set; }
    public TechnicalInformation TechnicalInformation { get; set; }

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
