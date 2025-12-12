namespace exercise04;

public class Program
{
    public static void Main()
    {
        int minutes = 250;
        int hours = minutes / 60;
        int remainingMinutes = minutes % 60;

        Console.WriteLine($"Time: {hours} hours and {remainingMinutes} minutes.");
    }
}
