namespace exercise39;

public class Program
{
    public static void Main()
    {
        int selectedOption = 0;
        int generatedPassword = 1;
        int callPassword = 1;

        do
        {
            Console.WriteLine("1 - Generate new password");
            Console.WriteLine("2 - Call next password");
            Console.WriteLine("3 - Exit");
            Console.Write("Choose an option: ");
            selectedOption = Convert.ToInt32(Console.ReadLine());

            if (selectedOption == 1)
            {
                Console.WriteLine($"Password generated: {generatedPassword.ToString("D3")}\n");
                generatedPassword++;
            }
            else if (selectedOption == 2)
            {
                Console.WriteLine($"Password entered: {callPassword.ToString("D3")}\n");
                callPassword++;
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