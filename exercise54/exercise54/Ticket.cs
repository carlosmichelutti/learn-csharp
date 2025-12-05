public class Ticket
{
    public string Passenger { get; set; }
    public string Destination { get; set; }

    public Ticket(string passenger, string destination)
    {
        Passenger = passenger;
        Destination = destination;
    }
}
