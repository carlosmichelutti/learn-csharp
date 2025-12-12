namespace exercise06;

public class Program
{
    public static void Main()
    {
        double note1 = 7.2;
        double note2 = 8.3;
        double note3 = 9.1;
        double average = (note1 + note2 + note3) / 3;

        Console.WriteLine($"The average grade is: {average:F2}");
    }
}
