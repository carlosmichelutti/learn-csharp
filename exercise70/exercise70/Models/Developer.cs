namespace exercise70.Models;

internal class Developer : Employee
{
    public List<string> ProgrammingLanguages { get; set; }
    public string Level { get; set;  }
    public override string DetailedDescription => $"Name: {Name} - Position {Position} - Salary: {Salary}";

    public Developer(string name, string position, double salary, List<string> programmingLanguages, string level)
        : base(name, position, salary)
    {
        ProgrammingLanguages = programmingLanguages;
        Level = level;
    }
}
