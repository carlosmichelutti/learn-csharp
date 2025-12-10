namespace exercise70.Models;

internal abstract class Employee
{
    public string Name { get; }
    public string Position { get; }
    public double Salary { get; }
    public abstract string DetailedDescription { get; }

    protected Employee(string name, string position, double salary)
    {
        Name = name;
        Position = position;
        Salary = salary;
    }
}
