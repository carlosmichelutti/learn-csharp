namespace exercise26;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        string ageRange;

        if (age >= 0 && age <= 12)
        {
            ageRange = "Children";
        }
        else if (age >= 13 && age <= 17)
        {
            ageRange = "Adolescent";
        }
        else if (age >= 18 && age <= 59)
        {
            ageRange = "Adult";
        }
        else
        {
            ageRange = "Elderly";
        }

        Console.WriteLine($"Your classification is: {ageRange}");
    }
}
