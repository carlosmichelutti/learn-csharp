namespace exercise20;

using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter the date (YYYY-MM-DD): ");
        string date = Console.ReadLine();
        bool match = Regex.IsMatch(date, @"^\d{4}-\d{2}-\d{2}$");

        if (match)
        {
            Console.WriteLine($"The date \"{date}\" is in the correct format.");
        }
        else
        {
            Console.WriteLine($"The date \"{date}\" is in an invalid format! Use YYYY-MM-DD.");
        }
    }
}