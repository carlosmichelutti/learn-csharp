namespace exercise48;

public class Program
{
    public static void Main()
    {
        List<string> namesList = new List<string> { "Ana", "Carlos", "Mariana", "João", "Lúcia" };

        Console.WriteLine($"Original list: {string.Join(", ", namesList)}");

        namesList.Sort();

        Console.WriteLine($"List after sorting: {string.Join(", ", namesList)}");

        namesList.Reverse();

        Console.WriteLine($"List after inversion: {string.Join(", ", namesList)}");

        string firstElement = namesList[0];
        namesList.Remove(firstElement);
        namesList.Add(firstElement);

        Console.WriteLine($"List after removing the first element and adding it at the end: {string.Join(", ", namesList)}");

        Console.WriteLine($"The person drawn was: {namesList[3]}");
    }
}
