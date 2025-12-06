namespace exercise37;

public class Program
{
    public static void Main()
    {
        int secretNumber = 7;
        int userNumber = 0;
        int attempts = 1;

        do
        {
            Console.Write("Try to guess the number between 1 and 10: ");
            userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber == secretNumber)
            {
                Console.WriteLine($"Congratulations, you got it right on {attempts} tries!");
            }
            else
            {
                Console.WriteLine("Wrong number! Please try again.");
                attempts++;
            }
        } while (userNumber != secretNumber);
    }
}