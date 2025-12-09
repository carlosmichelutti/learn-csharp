namespace Exercise68.Models;

public class Item
{
    private int _stock;
    private double _price;
    public string Name { get; set; }
    public int Stock
    {
        get => _stock;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(Stock), "The stock cannot be negative.");
            _stock = value;
        }
    }
    public double Price
    {
        get => _price;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(Price), "The price cannot be negative.");
            _price = value;
        }
    }
    public bool IsAvailable => Stock > 0;
    public string DetailedDescription => $"Item: {this.Name} - Price: {this.Price:F2} - Stock: {this.Stock}";

    public Item(string name, int stock, double price)
    {
        Name = name;
        Stock = stock;
        Price = price;
    }
}
