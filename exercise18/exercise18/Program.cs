namespace exercise18;

using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter the receipt text: ");
        string receipt = Console.ReadLine();
        string match = Regex.Match(receipt, @"(\d+,\d+)").Groups[0].Value;

        Console.WriteLine($"Value found: {match}");
    }
}
