namespace exercise27;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the operation (+, -, *, /): ");
        string operation = Console.ReadLine();

        int result = operation switch
        {
            "+" => (number1 + number2),
            "-" => (number1 - number2),
            "*" => (number1 * number2),
            "/" => (number1 / number2),
            _ => 0
        };
        Console.WriteLine($"Result: {result}");
    }
}