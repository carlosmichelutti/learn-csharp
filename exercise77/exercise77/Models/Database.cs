namespace exercise77.Models;

internal class Database : IStorable
{
    public string DatabaseName { get; }

    public Database(string databaseName)
    {
        DatabaseName = databaseName;
    }

    public void Save()
    {
        Console.WriteLine($"Saving data to the database \"{DatabaseName}\"");
        return;
    }

    public void Restore()
    {
        Console.WriteLine($"Restoring data from the database \"{DatabaseName}\"");
        return;
    }
}
