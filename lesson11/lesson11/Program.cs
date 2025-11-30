namespace lesson11;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a number from 1 to 10:");
        int number = Convert.ToInt32(Console.ReadLine());

        switch (number)
        {
            case 1: // if the number is equal to 1
                Console.Write("The number equals 1");
                break;

            case 2: // if the number is equal to 2
                Console.WriteLine("The number equals 2");
                break;

            case 3: // if the number is equal to 3
                Console.WriteLine("The number equals 3");
                break;

            case 4: // if the number is equal to 4
                Console.WriteLine("The number equals 4");
                break;

            case 5: // if the number is equal to 5
                Console.WriteLine("The number equals 5");
                break;

            case 6: // if the number is equal to 6
                Console.WriteLine("The number equals 6");
                break;

            case 7: // if the number is equal to 7
                Console.WriteLine("The number equals 7");
                break;

            case 8: // if the number is equal to 8
                Console.WriteLine("The number equals 8");
                break;

            case 9: // if the number is equal to 9
                Console.WriteLine("The number equals 9");
                break;

            case 10: // if the number is equal to 10
                Console.WriteLine("The number equals 10");
                break;

            default: // if the number is not between 1 and 10
                Console.WriteLine("Invalid number.");
                break;
        }
    }
}