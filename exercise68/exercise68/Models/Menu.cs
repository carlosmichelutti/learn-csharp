namespace exercise68.Models;

internal class Menu
{
    private readonly List<Item> _items = new List<Item>();

    public void AddItem(Item item)
    {
        _items.Add(item);
    }

    public void ShowItems()
    {
        Console.WriteLine("Menu items:");
        foreach (Item item in _items)
        {
            Console.WriteLine(item.DetailedDescription);
        }
        Console.WriteLine();
    }
}
