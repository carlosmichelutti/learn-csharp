namespace exercise03;

public class Program
{
    public static void Main()
    {
        double mile = 1.60934;
        int miles = 10;
        double kilometers = miles * mile;

        Console.WriteLine($"{miles} miles is equivalent to {kilometers} kilometers.");
    }
}