namespace exercise19;

using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        Console.Write("Type your phrase: ");
        string phrase = Console.ReadLine().Trim();
        phrase = Regex.Replace(phrase, @"\s+", " ");

        Console.WriteLine($"Clean text: {phrase}");
    }
};