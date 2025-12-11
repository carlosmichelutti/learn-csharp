namespace exercise73.Models;

internal class Tablet : ElectronicProducts
{
    public string ScreenType { get; set; }

    public Tablet(string brand, string model, double price, string screenType)
        : base(brand, model, price)
    {
        ScreenType = screenType;
    }

    public override string DisplayInformation()
    {
        return $"{base.DisplayInformation()}, Screen Type: {ScreenType}.";
    }
}
