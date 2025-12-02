namespace exercise34;

public class Program
{
    public static void Main()
    {
        int[] numbers = { 5, 42, 8, 11, 23, 1, 14, 30, 19, 27, 36, 2, 50, 7, 18, 9 };
        int firstDigit = numbers.IndexOf(19);
        int secondDigit = numbers.IndexOf(42);
        int thirdDigit = numbers.IndexOf(7);

        Console.WriteLine($"Padlock combination: {firstDigit}-{secondDigit}-{thirdDigit}");
    }
}