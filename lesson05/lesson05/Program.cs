namespace aula05;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number1 = Convert.ToInt32(Console.ReadLine()); // asking the user for a number and converting it to an integer
        Console.WriteLine("Enter another number: ");
        int number2 = Convert.ToInt32(Console.ReadLine()); // asking the user for another number and converting it to an integer

        int sum = number1 + number2; // Adding the two numbers
        int subtraction = number1 - number2; // Subtracting the two numbers
        int multiplication = number1 * number2; // Multiplying the two numbers
        int division = number1 / number2; // dividing the two numbers
        int module = number1 % number2; // calculating the remainder of the division of the two numbers

        Console.WriteLine("The sum of " + number1 + " and " + number2 + " equals " + sum);
        Console.WriteLine("The subtraction of " + number1 + " and " + number2 + " equals " + subtraction);
        Console.WriteLine("The multiplication of " + number1 + " and " + number2 + " equals " + multiplication);
        Console.WriteLine("The division of " + number1 + " and " + number2 + " equals " + division);
        Console.WriteLine("The module of " + number1 + " and " + number2 + " equals " + module);
    }
}