namespace exercise32;

public class Program
{
    public static void Main()
    {
        double[] donations = { 103.54, 259.72, 82.16, 154.87, 364.45, 14.49 };
        double total = 0;

        foreach (double value in donations)
        {
            total += value;
        }

        Console.WriteLine($"Total donations: ${total}");
    }
}