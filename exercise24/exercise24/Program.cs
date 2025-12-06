namespace exercise24;

public class Program
{
    public static void Main()
    {
        Console.Write("Please provide the student's final grade: ");
        double studentNote = Convert.ToDouble(Console.ReadLine());
        char performanceRating;

        if (studentNote >= 9)
        {
            performanceRating = 'A';
        }
        else if (studentNote >= 7)
        {
            performanceRating = 'B';
        }
        else if (studentNote >= 5)
        {
            performanceRating = 'C';
        }
        else
        {
            performanceRating = 'D';
        }

        Console.WriteLine($"The student received a grade of {performanceRating}.");
    }
}