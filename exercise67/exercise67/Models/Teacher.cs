namespace Exercise67.Models;

public class Teacher
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    private List<Discipline> _disciplines = new List<Discipline>();
    public string DetailedDescription => $"Teacher: {FirstName} {LastName}";

    public Teacher(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public void AddDiscipline(Discipline discipline)
    {
        _disciplines.Add(discipline);
    }

    public void ShowDisciplines()
    {
        Console.WriteLine($"Subjects taught by Professor {FirstName}: ");
        foreach (Discipline discipline in _disciplines)
        {
            Console.WriteLine(discipline.Name);
        }
        Console.WriteLine("");
    }
}
