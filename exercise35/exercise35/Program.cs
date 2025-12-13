namespace exercise35;

public class Program
{
    public static void Main()
    {
        int totalSales = 0;
        int salePrice;

        do
        {
            Console.Write("Enter the sale amount (or 0 to exit): ");
            salePrice = Convert.ToInt32(Console.ReadLine());
            totalSales += salePrice;
        } while (salePrice != 0);

        Console.WriteLine($"Total sales for the day: ${totalSales}");
    }
}
