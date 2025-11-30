namespace lesson12;

public class Program
{
    public static void Main()
    {
        int number1 = 1;
        while (number1 <= 10) // Loop while increasing
        {
            Console.WriteLine("The value of number1 is " + number1);
            number1++;
        }
        Console.WriteLine("\n");

        int number2 = 10;
        while (number2 >= 1) // Loop while decreasing
        {
            Console.WriteLine("The value of number2 is " + number2);
            number2--;
        }
        Console.WriteLine("\n");
    }
}