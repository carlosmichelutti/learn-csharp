namespace exercise41;

public class Program
{
    public static void Main()
    {
        for (int number = 1; number <= 20; number++)
        {
            if (number % 3 == 0)
            {
                continue;
            }
            Console.WriteLine(number);
        }
    }
}