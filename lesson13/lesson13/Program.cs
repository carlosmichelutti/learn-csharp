namespace lesson13;

public class Program
{
    public static void Main()
    {
        int number1 = 1;
        do // Loop while increasing
        {
            Console.WriteLine("The value of number1 is " + number1);
            number1++;
        } while (number1 <= 10);
        Console.WriteLine("\n");

        int number2 = 10;
        do // Loop while decreasing
        {
            Console.WriteLine("The value of number2 is " + number2);
            number2--;
        } while (number2 >= 1);
        Console.WriteLine("\n");
    }
}