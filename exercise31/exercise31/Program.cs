namespace exercise31;

public class Program
{
    public static void Main()
    {
        string[] registeredUsers = ["Carlos", "Bruno", "Miguel"];
        Console.WriteLine("Authentication System");
        Console.WriteLine("---------------------");
        Console.Write("Enter your username: ");
        string username = Console.ReadLine();

        if (registeredUsers.Contains(username))
        {
            Console.WriteLine($"Welcome, {username}!");
        }
        else
        {
            Console.WriteLine("User not registered.");
            Console.WriteLine("Available options:");
            Console.WriteLine("[1] Register new user");
            Console.WriteLine("[2] Access as guest");
            Console.WriteLine("[3] Quit");
            int selectedOption = Convert.ToInt32(Console.ReadLine());
            switch (selectedOption)
            {
                case 1:
                    Console.WriteLine($"New user \"{username}\" successfully registered!");
                    break;

                case 2:
                    Console.WriteLine("Access granted as a guest.");
                    break;

                case 3:
                    Console.WriteLine("Exiting the system...");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
