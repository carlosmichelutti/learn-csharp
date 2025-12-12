namespace exercise16;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter the customer's name: ");
        string nameCustomer = Console.ReadLine();
        Console.Write("Enter the customer's address: ");
        string addressCustomer = Console.ReadLine();
        Console.Write("Enter the shipping cost: ");
        double shippingCost = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the delivery date: ");
        var deliveryDate = Console.ReadLine();

        Console.WriteLine("\n======== DELIVERY REPORT ========\n");
        Console.WriteLine($"Customer: {nameCustomer}");
        Console.WriteLine($"Address: {addressCustomer}");
        Console.WriteLine($"Shipping cost: ${shippingCost:F2}");
        Console.WriteLine($"Date: {deliveryDate}");
        Console.WriteLine("\n=================================\n");
    }
}
