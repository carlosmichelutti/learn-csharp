namespace exercise22;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter the balance: ");
        double saldo = Convert.ToDouble(Console.ReadLine());

        if (saldo > 0)
        {
            Console.WriteLine($"The balance is positive. Balance: ${saldo:F2}");
        }
        else if (saldo < 0)
        {
            Console.WriteLine($"The balance is negative. Balance: ${saldo:F2}");
        }
        else
        {
            Console.WriteLine($"The balance is zero. Balance: ${saldo:F2}");
        }
    }
}