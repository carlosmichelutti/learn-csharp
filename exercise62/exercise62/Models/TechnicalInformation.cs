namespace exercise62.Models;

public class TechnicalInformation
{
    public double SizeMB { get; set; }
    public string OperatingSystem { get; set; }

    public TechnicalInformation(double sizeMb, string operatingSystem)
    {
        SizeMB = sizeMb;
        OperatingSystem = operatingSystem;
    }
}
