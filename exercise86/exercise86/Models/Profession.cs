namespace exercise86.Models;

abstract class Profession
{
    public string Title { get; }

    public Profession(string title)
    {
        Title = title;
    }
}
