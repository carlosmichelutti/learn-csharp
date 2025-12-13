namespace exercise25;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter the password: ");
        string password = Console.ReadLine();
        Console.Write("Enter the access level: ");
        int accessLevel = Convert.ToInt32(Console.ReadLine());

        if (password == "42" && accessLevel >= 5)
        {
            Console.WriteLine("Access granted!");
        }
        else
        {
            Console.WriteLine("Access denied!");
        }
    }
}
