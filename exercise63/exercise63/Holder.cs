public class Holder
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Document { get; set; }
    public DateTime DateBirth { get; set; }
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