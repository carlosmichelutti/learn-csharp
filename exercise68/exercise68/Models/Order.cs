namespace exercise68.Models;

public class Order
{
    public int OrderNumber { get; set; }
    public double Price { get; }
    public Item Item { get; set; }
    public Table Table { get; set; }
    public string DetailedDescription => $"Order: {this.OrderNumber} - Item {this.Item.Name} - Table {this.Table.Number}";

    public Order(int orderNumber, Item item, Table table)
    {
        if (!item.IsAvailable)
            throw new InvalidOperationException($"Item '{item.Name}' is out of stock.");

        OrderNumber = orderNumber;
        Item = item;
        Table = table;
        Price = item.Price;

        Item.Stock--;
    }
}
