namespace exercise21;

using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        Console.Write("Type the text: ");
        string text = Console.ReadLine();
        text = Regex.Replace(text, @"[http|https]+://\S+", "[LINK]");

        Console.WriteLine(text);
    }
}
