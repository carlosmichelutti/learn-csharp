namespace lesson16;

public class Program
{
    public static void Main()
    {
        int index = 0;
        string[] fruitsList = { "apple", "banana", "cashew", "manga" }; // declaring a string array named after fruits.

        Console.WriteLine($"Number of items in the array: {fruitsList.Length}\n");

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
        foreach (string fruit in fruitsList) // looping through each item in the array
        {
            Console.WriteLine($"Fruit from index {index}: {fruit}");
            index++;
        }
        Console.WriteLine("");

        int[] intList = new int[3]; // declaring an array of numbers with no predefined elements.
        intList[0] = 0; // defining a value for index 0
        intList[1] = 10; // defining a value for index 1
        intList[2] = 20; // defining a value for index 2

        index = 0;
        foreach (int number in intList) // looping through each item in the array
        {
            Console.WriteLine($"Number from index {index}: {number}");
            index++;
        }
    }
}