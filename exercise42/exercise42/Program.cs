namespace exercise42;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter a number to calculate the multiplication table: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}