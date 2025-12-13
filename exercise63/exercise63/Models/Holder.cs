namespace exercise63.Models;

internal class Holder
{
    public string FirstName { get; }
    public string LastName { get; }
    public string Document { get; }
    public DateTime DateBirth { get; }
    public int Age => (int)((DateTime.Today - DateBirth).TotalDays / 365);
    public string DetailedDescription => $"Holder: {this.FirstName} {this.LastName} - Document: {this.Document} - Date of Birth {this.DateBirth:dd/MM/yyyy}";

    public Holder(string firstName, string lastName, string document, DateTime dateBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        Document = document;
        DateBirth = dateBirth;

        if (Age < 18)
            throw new ArgumentOutOfRangeException(nameof(Age), "Only adults can create an account.");
    }
}
