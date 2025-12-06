namespace exercise22;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter the balance: ");
        double balance = Convert.ToDouble(Console.ReadLine());

        if (balance > 0)
        {
            Console.WriteLine($"The balance is positive. Balance: ${balance:F2}");
        }
        else if (balance < 0)
        {
            Console.WriteLine($"The balance is negative. Balance: ${balance:F2}");
        }
        else
        {
            Console.WriteLine($"The balance is zero. Balance: ${balance:F2}");
        }
    }
}