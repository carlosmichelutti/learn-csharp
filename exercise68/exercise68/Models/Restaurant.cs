namespace exercise68.Models;

internal class Restaurant
{
    public string Name { get; set; }
    public Menu Menu;
    public List<Table> Tables = new List<Table>();

    public Restaurant(string name, Menu menu, List<Table> tables)
    {
        Name = name;
        Menu = menu;
        Tables = tables;
    }

    public void ShowAvailableTables()
    {
        foreach (Table table in Tables)
        {
            if (!table.Reserved)
            {
                Console.WriteLine($"Table {table.Number} is available.");
            }
        }
        Console.WriteLine();
    }
}
