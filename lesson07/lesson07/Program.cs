namespace aula07;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Assignment Operators");

        // Initialize a variable
        int number = 10;
        Console.WriteLine("Number value: " + number);

        // Simple assignment operator (=)
        number = 20;
        Console.WriteLine("Simple assignment operator (=)");
        Console.WriteLine("New Value of number: " + number);

        // Composite assignment (++/--)
        number++; // = number = number + 1
        Console.WriteLine("Composite assignment (++)");
        Console.WriteLine("New Value of number: " + number);
        number--; // = number = number - 1
        Console.WriteLine("Composite assignment (--)");
        Console.WriteLine("New Value of number: " + number);

        // Composite assignment (+=/-=/*=//=)
        number += 10; // = number = number + 10
        Console.WriteLine("Composite assignment (+=)");
        Console.WriteLine("New Value of number: " + number);

        number -= 2; // = number = number - 2
        Console.WriteLine("Composite assignment (-=)");
        Console.WriteLine("New Value of number: " + number);

        number *= 2; // = number = number * 2
        Console.WriteLine("Composite assignment (*=)");
        Console.WriteLine("New Value of number: " + number);

        number /= 2; // = number = number / 2
        Console.WriteLine("Composite assignment (/=)");
        Console.WriteLine("New Value of number: " + number);
    }
}