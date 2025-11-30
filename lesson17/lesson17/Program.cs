namespace lesson17;

public class Program
{
    public static void Main()
    {
        int index = 0;
        List<string> fruitsList = new List<string>() { "apple", "banana", "cashew", "manga" }; // declaring a string list named after fruitsList.

        Console.WriteLine($"Number of items in the list: {fruitsList.Count}\n");

        Console.WriteLine($"Fruit from index 0: {fruitsList[0]}");
        Console.WriteLine($"Fruit from index 1: {fruitsList[1]}");
        Console.WriteLine($"Fruit from index 2: {fruitsList[2]}");
        Console.WriteLine($"Fruit from index 3: {fruitsList[3]}");
        Console.WriteLine("");

        Console.WriteLine($"Value before the change: {fruitsList[1]}");
        fruitsList[1] = "pineapple"; // changing the value of index 1
        Console.WriteLine($"Value after the change: {fruitsList[1]}");
        Console.WriteLine("");

        index = 0;
        foreach (string fruit in fruitsList) // looping through each item in the list
        {
            Console.WriteLine($"Fruit from index {index}: {fruit}");
            index++;
        }
        Console.WriteLine("");

        fruitsList.Add("orange"); // adding item to the end of the list
        fruitsList.Add("grape"); // adding item to the end of the list

        index = 0;
        foreach (string fruit in fruitsList) // looping through each item in the list
        {
            Console.WriteLine($"Fruit from index {index}: {fruit}");
            index++;
        }
        Console.WriteLine("");

        fruitsList.Remove("cashew"); // removing item from list

        index = 0;
        foreach (string fruit in fruitsList) // looping through each item in the list
        {
            Console.WriteLine($"Fruit from index {index}: {fruit}");
            index++;
        }
        Console.WriteLine("");

        List<int> numbers = new List<int>(); // Declaring a list of numbers with no predefined elements.
        numbers.Add(0); // adding item to the end of the list
        numbers.Add(10); // adding item to the end of the list
        numbers.Add(20); // adding item to the end of the list

        index = 0;
        foreach (int number in numbers) // looping through each item in the list
        {
            Console.WriteLine($"Number from index {index}: {number}");
            index++;
        }
        Console.WriteLine("");
    }
}