namespace exercise56.Models;

public class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }

    public Employee(string name, string position)
    {
        Name = name;
        Position = position;
    }

    public void Promote(string newPosition)
    {
        if (newPosition == Position)
        {
            Console.WriteLine("Error: The new position must be different from the current position.\n");
        }
        else
        {
            Position = newPosition;
            Console.WriteLine("Promotion successfully completed!\n");
        }
    }
}
