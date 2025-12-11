namespace exercise73.Models;

internal class Laptop : ElectronicProducts
{
    public string OperatingSystem { get; set; }

    public Laptop(string brand, string model, double price, string operatingSystem)
        : base(brand, model, price)
    {
        OperatingSystem = operatingSystem;
    }

    public override string DisplayInformation()
    {
        return $"{base.DisplayInformation()}, Operating System: {OperatingSystem}.";
    }
}
