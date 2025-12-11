namespace exercise73.Models;

internal class Smartphone : ElectronicProducts
{

    public string OperatingSystem { get; set; }

    public Smartphone(string brand, string model, double price, string operatingSystem)
        : base(brand, model, price)
    {
        OperatingSystem = operatingSystem;
    }

    public override string DisplayInformation()
    {
        return $"{base.DisplayInformation()}, Operating System: {OperatingSystem}.";
    }
}
