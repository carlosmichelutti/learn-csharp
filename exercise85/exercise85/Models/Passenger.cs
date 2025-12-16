namespace exercise85.Models;

internal class Passenger : Person
{
    public int QuantityTickets { get; }

    public Passenger(string name, int age, int quantityTickets)
        : base(name, age)
    {
        QuantityTickets = quantityTickets;
    }

    public override string ToString()
    {
        return $"Passenger: {Name} - Age: {Age} - Tickets: {QuantityTickets}";
    }
}
