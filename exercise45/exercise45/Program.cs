namespace exercise45;

public class Program
{
    public static void Main()
    {
        int quantityOddNumbers = 0;
        int quantityEvenNumbers = 0;

        for (int number = 1; number <= 10; number++)
        {
            Console.Write("Enter a number: ");
            int numberUser = Convert.ToInt32(Console.ReadLine());

            if (numberUser % 2 == 0)
            {
                quantityEvenNumbers++;
            }
            else
            {
                quantityOddNumbers++;
            }
        }

        Console.WriteLine($"You entered {quantityOddNumbers} odd numbers.");
        Console.WriteLine($"You entered {quantityEvenNumbers} even numbers.");
    }
}
