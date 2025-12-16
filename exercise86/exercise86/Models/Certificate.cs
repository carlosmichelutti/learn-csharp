namespace exercise86.Models;

internal class Certificate
{
    public Profession Profession { get; }

    public Certificate(Profession profession)
    {
        Profession = profession;
    }

    public override string ToString()
    {
        return $"Certificate issued to: {Profession.Title}";
    }
}
