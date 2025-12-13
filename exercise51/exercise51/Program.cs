namespace exercise51;

public class Program
{
    public static void Main()
    {
        Dictionary<int, string> inventory = new Dictionary<int, string>()
        {
            { 1, "Longsword" },
            { 2, "Short Bow" },
            { 3, "Iron Shield" }
        };

        Console.WriteLine("Items in the initial inventory:");
        foreach (KeyValuePair<int, string> item in inventory)
        {
            Console.WriteLine($"ID: {item.Key} - {item.Value}");
        }
        Console.WriteLine("");

        inventory.Remove(2);
        inventory.Add(4, "Life Potion");

        Console.WriteLine("Items in the updated inventory:");
        foreach (KeyValuePair<int, string> item in inventory)
        {
            Console.WriteLine($"ID: {item.Key} - {item.Value}");
        }
        Console.WriteLine("");
    }
}
