namespace exercise87.Models;

internal class TemperatureSensor : ISensor
{
    public void Activate()
    {
        Console.WriteLine("Temperature sensor activated");
    }

    public void Disable()
    {
        Console.WriteLine("Temperature sensor disabled");
    }
}
