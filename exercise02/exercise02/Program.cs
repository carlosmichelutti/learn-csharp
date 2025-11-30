namespace exercise02;

public class Program
{
    public static void Main()
    {
        double donatedAmount = 3000.00;
        bool anonymousDonation = true;
        char typeAccount = 'C';

        Console.WriteLine($"Amount received: ${donatedAmount}");
        Console.WriteLine($"Anonymous donation: {anonymousDonation}");
        Console.WriteLine($"Account type: {typeAccount}");
    }
}