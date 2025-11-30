namespace exercise08;

public class Program
{
    public static void Main()
    {
        int quantityLives = 5;
        int FinalNumberOfLives = 0;
        quantityLives--;
        quantityLives += 2;
        FinalNumberOfLives = quantityLives;

        Console.WriteLine($"Final Lives: {FinalNumberOfLives}");
    }
}