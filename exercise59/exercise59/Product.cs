public class Product
{
    public string Name { get; set; }
    private int QuantityStock { get; set; }

    public Product(string name, int quantityStock)
    {
        Name = name;
        QuantityStock = quantityStock;
    }

    public void RemoveFromStock(int quantityRemove)
    {
        if (quantityRemove <= QuantityStock)
        {
            Console.WriteLine($"Withdrawal of {quantityRemove} units successfully completed.");
            QuantityStock -= quantityRemove;
            return;
        }
        Console.WriteLine($"Error: Insufficient stock for withdrawal of {quantityRemove} units.");
    }

    public void DisplayStock()
    {
        Console.WriteLine($"Product: {Name} - Stock: {QuantityStock}");
    }
}
