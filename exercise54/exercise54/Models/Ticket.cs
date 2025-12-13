namespace Exercise54.Models;

internal class Ticket
{
    public string Passenger { get; }
    public string Destination { get; }

    public Ticket(string passenger, string destination)
    {
        Passenger = passenger;
        Destination = destination;
    }
}
