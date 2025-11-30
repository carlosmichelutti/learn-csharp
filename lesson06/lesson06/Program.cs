namespace aula06;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine()); // asking the user for a number

        if (number % 2 == 0) // checking if it is even or odd
        {
            Console.WriteLine("The number " + number + " is an even number.");
        }
        else
        {
            Console.WriteLine("The number " + number + " is an odd number.");
        }
    }
}