namespace exercise09;

public class Program
{
    public static void Main()
    {
        decimal currentSalary = 3000.00m;
        decimal percentAgeIncrease = 20.00m;
        decimal newSalary = currentSalary * (1 + (percentAgeIncrease / 100));

        Console.WriteLine($"The new salary is ${newSalary:F2}");
    }
}
