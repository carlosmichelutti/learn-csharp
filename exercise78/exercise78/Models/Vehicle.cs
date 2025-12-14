namespace exercise78.Models;

internal class Vehicle
{
    public string Plate { get; set; }
    public double CurrentSpeed { get; private set; }

    public Vehicle(string plate)
    {
        Plate = plate;
        CurrentSpeed = 0;
    }

    public void UpdateSpeed(double newSpeed)
    {
        CurrentSpeed = newSpeed;
    }

    public override string ToString()
    {
        return $"Vehicle: {Plate} - Current speed: {CurrentSpeed:F2} km/h";
    }
}

