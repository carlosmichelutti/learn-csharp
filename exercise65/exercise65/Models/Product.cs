namespace exercise65.Models;

internal class Product
{
    private double _price;
    private int _stock;
    public string Name { get; set; }
    public string Brand { get; set; }
    public double Price
    {
        get => _price;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(Price), "Price cannot be negative.");
            _price = value;
        }
    }
    public int Stock
    {
        get => _stock;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(Stock), "Stock cannot be negative.");
            _stock = value;
        }
    }
    public string DetailedDescription => $"Product: {this.Name} - Brand: {this.Brand} - Stock: {this.Stock} - Price: {this.Price:F2}";

    public Product(string name, string brand, double price, int stock)
    {
        Name = name;
        Brand = brand;
        Price = price;
        Stock = stock;
    }
}
