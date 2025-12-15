namespace exercise83.Models;

internal class Contact
{
    public string Name { get; }
    public string PhoneNumber { get; }

    public Contact(string name, string phoneNumber)
    {
        Name = name;
        PhoneNumber = phoneNumber;
    }
}
