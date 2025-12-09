namespace Exercise67.Models;

public class Discipline
{
    public string Name { get; set; }
    private List<Student> _students = new List<Student>();

    public Discipline(string name)
    {
        Name = name;
    }

    public void AddStudent(Student student)
    {
        _students.Add(student);
    }

    public void ShowStudents()
    {
        Console.WriteLine($"Students enrolled in the {Name} course:");
        foreach (Student student in _students)
        {
            Console.WriteLine(student.DetailedDescription);
        }
    }
}
