namespace exercise92.Models;

internal class Media
{
    public string Name { get; }

    public Media(string name)
    {
        Name = name;
    }

    public virtual void ShowDetails()
    {
        return;
    }
}
