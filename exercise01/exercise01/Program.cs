namespace exercise01;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter your year of birth: ");
        int yearBirth = Convert.ToInt32(Console.ReadLine());
        int currentYear = 2025;
        int userAge = currentYear - yearBirth;

        Console.WriteLine($"Your age is {userAge} years old");
    }
}
