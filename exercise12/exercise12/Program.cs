namespace exercise12;

public class Program
{
    public static void Main()
    {
        Console.Write("Type some text: ");
        string textUser = Console.ReadLine();
        int numberCharacters = textUser.Length;

        Console.WriteLine($"The sentence contains {numberCharacters} characters.");
    }
}