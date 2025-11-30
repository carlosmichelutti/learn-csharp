namespace exercise20;

using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        Console.Write("Digite a data (YYYY-MM-DD): ");
        string date = Console.ReadLine();
        bool match = Regex.IsMatch(date, @"^\d{4}-\d{2}-\d{2}$");

        if (match)
        {
            Console.WriteLine($"A data \"{date}\" está no formato correto.");
        }
        else
        {
            Console.WriteLine($"A data \"{date}\" está no formato inválido! Use YYYY-MM-DD.");
        }
    }
}