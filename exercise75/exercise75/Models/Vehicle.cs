namespace exercise75.Models;

internal class Vehicle : IFlyable, IPilotable
{
    public void Brake()
    {
        Console.WriteLine("Braking the vehicle...");
        return;
    }

    public void Accelerate()
    {
        Console.WriteLine("Accelerating the vehicle...");
        return;
    }

    public void Fly()
    {
        Console.WriteLine("Taking off the vehicle...");
        return;
    }

    public void Land()
    {
        Console.WriteLine("Landing the vehicle...");
        return;
    }
}
