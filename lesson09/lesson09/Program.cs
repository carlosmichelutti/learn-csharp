namespace lesson09;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Logical Operators");

        bool isLogged = true;
        bool hasAdminAccess = false;

        Console.WriteLine("\nUser Information");
        Console.WriteLine("Logged-in User: " + isLogged);
        Console.WriteLine("Access to the administrator panel: " + hasAdminAccess);

        Console.WriteLine("\nPermissions");

        // Operator Or (||)
        if (isLogged || hasAdminAccess)
        {
            Console.WriteLine("Access to the system granted.");
        }
        else
        {
            Console.WriteLine("System access denied.");
        }

        // Operator And (&&)
        if (isLogged && hasAdminAccess)
        {
            Console.WriteLine("Access to the admin panel granted.");
        }
        else
        {
            Console.WriteLine("Access to the admin panel denied.");
        }

        // Operator Not (!)
        if (!isLogged)
        {
            Console.WriteLine("User logged out of the system.");
        }
        else
        {
            Console.WriteLine("User already logged into the system.");
        }
    }
}