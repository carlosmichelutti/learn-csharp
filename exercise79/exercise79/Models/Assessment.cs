namespace exercise79.Models;

internal class Assessment
{
    public string Student { get; set; }
    public double Grade { get; private set; }

    public Assessment(string student)
    {
        Student = student;
    }

    public void AssignGrade(double newGrade)
    {
        if (newGrade < 0 || newGrade > 10) Console.WriteLine("Error: The grade must be between 0 and 10.");
        Grade = newGrade;
    }

    public override string ToString()
    {
        return $"Student: {Student} - Grade awarded: {Grade:F2}";
    }
}
