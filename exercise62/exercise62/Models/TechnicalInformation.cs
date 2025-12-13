namespace Exercise62.Models;

internal class TechnicalInformation
{
    public double SizeMB { get; }
    public string OperatingSystem { get; }

    public TechnicalInformation(double sizeMb, string operatingSystem)
    {
        SizeMB = sizeMb;
        OperatingSystem = operatingSystem;
    }
}
