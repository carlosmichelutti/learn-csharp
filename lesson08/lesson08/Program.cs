namespace aula08;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Relational Operators\n");
        Console.WriteLine("Enter a number1: "); // asking the user for a number
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a number2: "); // asking the user for another number
        int number2 = Convert.ToInt32(Console.ReadLine());
        string result;

        // Equality Operator (==)
        if (number1 == number2)
        {
            result = "number1 is equal to number2";
        }
        else
        {
            result = "number1 is different from number2";
        }
        Console.WriteLine("\nEquality (==): " + result);

        // Difference operator
        if (number1 != number2)
        {
            result = "number1 is different from number2";
        }
        else
        {
            result = "number1 is equal to number2";
        }
        Console.WriteLine("\nDifference (!=): " + result);

        // Operator greater than (>)
        if (number1 > number2)
        {
            result = "number1 is greater than number2";
        }
        else
        {
            result = "number1 is not greater than number2";
        }
        Console.WriteLine("\nGreater than (>): " + result);

        // Operator Less Than (<)
        if (number1 < number2)
        {
            result = "number1 is less than number2";
        }
        else
        {
            result = "number1 is not less than number2";
        }
        Console.WriteLine("\nLess than (<): " + result);

        // Greater than or equal to operator (>=)
        if (number1 >= number2)
        {
            result = "number1 is greater than or equal to number2";
        }
        else
        {
            result = "number1 is not greater than or equal to number2.";
        }
        Console.WriteLine("\nGreater than or equal to (>=): " + result);

        // Less than or equal to operator (<=)
        if (number1 <= number2)
        {
            result = "number1 is less than or equal to number2";
        }
        else
        {
            result = "number1 is not less than or equal to number2";
        }
        Console.WriteLine("\nLess than or equal to (<=): " + result);
    }
}