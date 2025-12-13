namespace exercise73.Models;

internal class ElectronicProducts
{
    public string Brand { get; }
    public string Model { get; }
    public double Price { get; }

    public ElectronicProducts(string brand, string model, double price)
    {
        Brand = brand;
        Model = model;
        Price = price;
    }

    public virtual string DisplayInformation()
    {
        return $"Brand: {Brand}, Model: {Model}, Price: {Price:F2}";
    }
}
