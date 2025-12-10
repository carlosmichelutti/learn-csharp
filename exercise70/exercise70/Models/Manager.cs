namespace exercise70.Models;

internal class Manager : Employee
{
    public string Sector { get; set; }
    public override string DetailedDescription => $"Name: {Name} - Position {Position} - Salary: {Salary}";

    public Manager(string name, string position, double salary, string sector)
        : base(name, position, salary)
    {
        Sector = sector;
    }
}
