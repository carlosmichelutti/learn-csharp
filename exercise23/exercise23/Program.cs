namespace exercise23;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter the product code (1 or 2): ");
        int numberUser = Convert.ToInt32(Console.ReadLine());

        if (numberUser == 1)
        {
            Console.WriteLine("Perishable.");
        }
        else if (numberUser == 2)
        {
            Console.WriteLine("Non-perishable.");
        }
        else
        {
            Console.WriteLine($"Warning! Invalid code \"{numberUser}\".");
        }
    }
}