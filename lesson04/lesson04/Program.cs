namespace Aula04;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter your name: ");
        string nameUser = Console.ReadLine(); // requesting the program's username
        Console.WriteLine("Enter your age: ");
        int ageUser = Convert.ToInt32(Console.ReadLine()); // requesting the user's age from the program and converting it to an integer.

        Console.WriteLine("Your name is: " + nameUser + "\nYou're " + ageUser + " years old.");
    }
}