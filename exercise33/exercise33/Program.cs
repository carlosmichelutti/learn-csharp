namespace exercise33;

public class Program
{
    public static void Main()
    {
        string[] namesArray = { "Fernanda", "Eduardo", "Gustavo", "Carolina", "Alice", "Bruno", "Daniel" };
        namesArray.Sort();

        Console.WriteLine($"The third name in the list after sorting is: {namesArray[2]}");
    }
}
