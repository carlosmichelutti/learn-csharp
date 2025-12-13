namespace exercise40;

public class Program
{
    public static void Main()
    {
        int selectedOption = 0;
        int temperature;
        int temperatureConverted;

        do
        {
            Console.WriteLine("1 - Celsius to Fahrenheit");
            Console.WriteLine("2 - Fahrenheit to Celsius");
            Console.WriteLine("3 - Exit");
            Console.Write("Choose an option: ");
            selectedOption = Convert.ToInt32(Console.ReadLine());

            if (selectedOption == 1)
            {
                Console.Write("Enter the temperature in Celsius: ");
                temperature = Convert.ToInt32(Console.ReadLine());
                temperatureConverted = (temperature * 9 / 5) + 32;
                Console.WriteLine($"{temperature}°C is equivalent to {temperatureConverted}°F\n");
            }
            else if (selectedOption == 2)
            {
                Console.Write("Enter the temperature in Fahrenheit: ");
                temperature = Convert.ToInt32(Console.ReadLine());
                temperatureConverted = (temperature - 32) * 5 / 9;
                Console.WriteLine($"{temperature}°F is equivalent to {temperatureConverted}°C\n");
            }
            else if (selectedOption == 3)
            {
                Console.WriteLine("Exiting the system.");
                break;
            }
            else
            {
                Console.WriteLine($"Option \"{selectedOption}\" is invalid.\n");
            }
        } while (true);
    }
}
