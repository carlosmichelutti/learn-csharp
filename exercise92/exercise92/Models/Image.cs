namespace exercise92.Models;

internal class Image : Media
{
    public string Resolution { get; }

    public Image(string name, string resolution)
        : base(name)
    {
        Resolution = resolution;
    }

    public override void ShowDetails()
    {
        Console.WriteLine($"Image: {Name} - Resolution: {Resolution}");
    }
}
