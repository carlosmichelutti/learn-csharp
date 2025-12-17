namespace exercise87.Models;

internal class PresenceSensor : ISensor
{
    public void Activate()
    {
        Console.WriteLine("Presence sensor activated");
    }

    public void Disable()
    {
        Console.WriteLine("Presence sensor deactivated");
    }
}
