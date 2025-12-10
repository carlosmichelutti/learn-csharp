namespace exercise70.Models;

internal class Analyst : Employee
{
    public List<string> Skills { get; }
    public string Level { get; }
    public override string DetailedDescription => $"Name: {Name} - Position {Position} - Salary: {Salary}";

    public Analyst(string name, string position, double salary, List<string> skills, string level)
        : base(name, position, salary)
    {
        Skills = skills;
        Level = level;
    }
}
