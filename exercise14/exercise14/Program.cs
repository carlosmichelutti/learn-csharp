namespace exercise14;

public class Program
{
    public static void Main()
    {
        string log = "2025-03-25,Error,File not found";
        string[] logArray = log.Split(",");

        Console.WriteLine($"Date: {logArray[0]}");
        Console.WriteLine($"Error type: {logArray[1]}");
        Console.WriteLine($"Message: {logArray[2]}");
    }
}