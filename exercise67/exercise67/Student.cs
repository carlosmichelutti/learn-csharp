public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateBirth { get; set; }
    public int Age => (int)((DateTime.Today - DateBirth).TotalDays / 365);
    public List<double> Notes = new List<double>();
    public string DetailedDescription => $"Name: {FirstName} {LastName} - Age: {Age}";

    public Student(string firstName, string lastName, DateTime dateBirth, List<double> notes)
    {
        FirstName = firstName;
        LastName = lastName;
        DateBirth = dateBirth;
        Notes = notes;
    }
}
