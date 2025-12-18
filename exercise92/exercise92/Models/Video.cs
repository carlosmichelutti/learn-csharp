namespace exercise92.Models;

internal class Video : Media
{
    public int Duration { get; }

    public Video(string name, int duration)
        : base(name)
    {
        Duration = duration;
    }

    public override void ShowDetails()
    {
        Console.WriteLine($"Video: {Name} - Duration: {Duration} minutes");
    }
}
