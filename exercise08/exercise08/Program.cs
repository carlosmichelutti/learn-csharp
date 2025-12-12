namespace exercise08;

public class Program
{
    public static void Main()
    {
        int quantityLives = 5;
        int finalNumberOfLives = 0;
        quantityLives--;
        quantityLives += 2;
        finalNumberOfLives = quantityLives;

        Console.WriteLine($"Final Lives: {finalNumberOfLives}");
    }
}
