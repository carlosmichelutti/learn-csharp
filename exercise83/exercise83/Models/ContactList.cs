namespace exercise83.Models;

internal class ContactList
{
    public string Owner { get; }
    private readonly List<Contact> Contacts;
    public int QuantityContacts => Contacts.Count;

    public ContactList(string owner)
    {
        Owner = owner;
        Contacts = new List<Contact>();
    }

    public bool AddContact(Contact contact)
    {
        if (Contacts.Any(c => c.Name == contact.Name))
        {
            Console.WriteLine("Contact with that name is already on the agenda.");
            return false;
        }

        Contacts.Add(contact);
        return true;
    }

    public void DisplayContacts()
    {
        Console.WriteLine($"Agenda of: {Owner}");
        Console.WriteLine("Contacts:");
        foreach (Contact contact in Contacts)
        {
            Console.WriteLine($" - {contact.Name} | {contact.PhoneNumber}");
        }
        Console.WriteLine($"Total contacts: {QuantityContacts}");
    }
}
