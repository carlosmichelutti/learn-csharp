namespace exercise73.Models;

internal class ElectronicProducts
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public double Price { get; set; }

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
