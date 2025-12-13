namespace exercise68.Models;

public class Table
{
    public int Number { get; set; }
    public bool Reserved { get; set; } = false;

    public Table(int number)
    {
        Number = number;
    }

    public void ReserveTable()
    {
        Reserved = true;
        Console.WriteLine($"Table {Number} successfully reserved!\n");
    }
}
