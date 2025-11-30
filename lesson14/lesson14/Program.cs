namespace lesson14;

public class Program
{
    public static void Main()
    {
        for (int number1 = 1; number1 <= 10; number1++) // Loop while increasing
        {
            Console.WriteLine($"The value of number1 is {number1}");
        }
        Console.WriteLine("");

        for (int number2 = 10; number2 >= 1; number2--) // Loop while decreasing
        {
            Console.WriteLine($"The value of number2 is {number2}");
        }
        Console.WriteLine("");

        Console.WriteLine("Enter a number to calculate its multiplication table:");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++) // A while loop to calculate the multiplication table from 1 to 10 of the chosen number.
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}