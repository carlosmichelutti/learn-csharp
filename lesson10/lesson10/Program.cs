namespace lesson10;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("Enter a number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter another number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        double result;

        // Select the mathematical operation
        Console.WriteLine("\nChoose a mathematical operation: ");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Subtraction (-)");
        Console.WriteLine("3. Multiplication (*)");
        Console.WriteLine("4. Division (/)");
        Console.WriteLine("Enter the operation number: ");
        int operation = Convert.ToInt32(Console.ReadLine());

        // Conditions
        if (operation == 1) // Sum
        {
            result = number1 + number2;
            Console.WriteLine(number1 + " + " + number2 + " = " + result);
        }
        else if (operation == 2) // Subtraction
        {
            result = number1 - number2;
            Console.WriteLine(number1 + " - " + number2 + " = " + result);
        }
        else if (operation == 3) // Multiplication
        {
            result = number1 * number2;
            Console.WriteLine(number1 + " * " + number2 + " = " + result);
        }
        else if (operation == 4) // Division
        {
            if (number2 != 0)
            {
                result = number1 / number2;
                Console.WriteLine(number1 + " / " + number2 + " = " + result);
            }
            else
            {
                Console.WriteLine("Error: It is not possible to divide a number by 0.");
            }
        }
        else
        {
            Console.WriteLine("Invalid operation.");
        }
    }
}