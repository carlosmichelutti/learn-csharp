namespace exercise36;

public class Program
{
    public static void Main()
    {
        int currentStock = 0;

        Console.WriteLine("Do you want to add a product to your inventory?");
        Console.WriteLine("1 - Yes | 0 - No");
        int response = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        while (response == 1)
        {
            Console.Write("Amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            currentStock += amount;

            Console.WriteLine($"Current stock: {currentStock}\n");

            Console.WriteLine("Do you wish to continue?");
            Console.WriteLine("1 - Yes | 0 - No");
            response = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
        }

        Console.WriteLine("Thank you for using our inventory system!");
    }
}