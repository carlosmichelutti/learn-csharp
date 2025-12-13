namespace Exercise59.Models;

internal class Product
{
    private int _quantityStock { get; set; }
    public string Name { get; set; }

    public Product(string name, int quantityStock)
    {
        Name = name;
        _quantityStock = quantityStock;
    }

    public void RemoveFromStock(int quantityRemove)
    {
        if (quantityRemove <= _quantityStock)
        {
            Console.WriteLine($"Withdrawal of {quantityRemove} units successfully completed.");
            _quantityStock -= quantityRemove;
            return;
        }
        Console.WriteLine($"Error: Insufficient stock for withdrawal of {quantityRemove} units.");
    }

    public void DisplayStock()
    {
        Console.WriteLine($"Product: {Name} - Stock: {_quantityStock}");
    }
}
