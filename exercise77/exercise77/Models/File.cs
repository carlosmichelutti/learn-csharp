namespace exercise77.Models;

internal class File : IStorable
{
    public string FileName { get; }

    public File(string fileName)
    {
        FileName = fileName;
    }

    public void Save()
    {
        Console.WriteLine($"Saving data to the file \"{FileName}\"");
        return;
    }

    public void Restore()
    {
        Console.WriteLine($"Restoring data from the file \"{FileName}\"");
        return;
    }
}
